using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
public sealed class Cleaner : CSharpSyntaxRewriter
{
    static Dictionary<string,int> baseArities = new();
    public static void ConfigureBases(string root) {
        var groups=new Dictionary<string,List<int>>();
        foreach(var file in Directory.EnumerateFiles(Path.Combine(root,".recon/complete"),"*.cs",SearchOption.AllDirectories)) {
            var tree=CSharpSyntaxTree.ParseText(File.ReadAllText(file));
            foreach(var type in tree.GetRoot().DescendantNodes().OfType<ClassDeclarationSyntax>()) {
                var key=type.Identifier.Text+"`"+(type.TypeParameterList?.Parameters.Count??0);
                var ctors=type.Members.OfType<ConstructorDeclarationSyntax>().Where(c=>!c.Modifiers.Any(SyntaxKind.StaticKeyword)).ToArray();
                var count=ctors.Length==0?0:ctors.Min(c=>c.ParameterList.Parameters.Count(p=>p.Default==null && !p.AttributeLists.ToString().Contains("Optional")));
                if(!groups.ContainsKey(key))groups[key]=new List<int>(); groups[key].Add(count);
            }
        }
        baseArities=groups.Where(kv=>kv.Value.Distinct().Count()==1).ToDictionary(kv=>kv.Key,kv=>kv.Value[0]);
    }
    public override SyntaxNode? VisitUsingDirective(UsingDirectiveSyntax node) {
        if(node.Alias==null && node.Name!=null && !node.Name.ToString().StartsWith("global::"))return node.WithName(ParseName("global::"+node.Name));
        return node;
    }
    public override SyntaxNode? VisitCastExpression(CastExpressionSyntax node) {
        if(node.Expression.IsKind(SyntaxKind.NullLiteralExpression))return DefaultExpression(node.Type);
        return base.VisitCastExpression(node);
    }

    static string Decode(string s) => Regex.Replace(s,"_([0-9A-F]{4})",m=>((char)Convert.ToInt32(m.Groups[1].Value,16)).ToString());
    static bool Explicit(string s) => s.Contains("_002E") && !s.StartsWith("_003C");
    static SyntaxTokenList NoAccess(SyntaxTokenList m) => TokenList(m.Where(t=>!new[]{"public","private","protected","internal","virtual","override","abstract","sealed"}.Contains(t.Text)));
    static ExplicitInterfaceSpecifierSyntax Interface(string s) => ExplicitInterfaceSpecifier(ParseName(s[..s.LastIndexOf('.')]));
    static SyntaxToken MemberName(string s) => Identifier(s[(s.LastIndexOf('.')+1)..]);
    static BlockSyntax ThrowBody() => Block(ThrowStatement(LiteralExpression(SyntaxKind.NullLiteralExpression)));
    public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        var n=(MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;
        if(Explicit(n.Identifier.Text)) {
            var decoded=Decode(n.Identifier.Text);
            n=n.WithIdentifier(MemberName(decoded)).WithExplicitInterfaceSpecifier(Interface(decoded)).WithModifiers(NoAccess(n.Modifiers));
        }
        var containing=node.Parent as TypeDeclarationSyntax;
        var bases=containing?.BaseList?.ToString()??"";
        if(n.Modifiers.Any(SyntaxKind.PrivateKeyword) && n.Identifier.Text is "MoveNext" or "SetStateMachine") {
            if(bases.Contains("IAsyncStateMachine")) n=n.WithModifiers(NoAccess(n.Modifiers)).WithExplicitInterfaceSpecifier(ExplicitInterfaceSpecifier(ParseName("global::System.Runtime.CompilerServices.IAsyncStateMachine")));
            else if(bases.Contains("IEnumerator") && n.Identifier.Text=="MoveNext") n=n.WithModifiers(NoAccess(n.Modifiers)).WithExplicitInterfaceSpecifier(ExplicitInterfaceSpecifier(ParseName("global::System.Collections.IEnumerator")));
        }
        // Dummy bodies cannot assign out parameters or materialize a ref return; throw null is another DummyDll stub form.
        if(n.Body!=null && (n.ParameterList.Parameters.Any(p=>p.Modifiers.Any(SyntaxKind.OutKeyword)) || n.ReturnType is RefTypeSyntax)) n=n.WithBody(ThrowBody());
        if(n.ExplicitInterfaceSpecifier!=null && n.Identifier.Text.StartsWith("get_") && n.ParameterList.Parameters.Count==0) {
            return PropertyDeclaration(n.ReturnType,n.Identifier.Text[4..]).WithExplicitInterfaceSpecifier(n.ExplicitInterfaceSpecifier).WithAttributeLists(n.AttributeLists).WithAccessorList(AccessorList(SingletonList(AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithBody(n.Body??ThrowBody()))));
        }
        return n;
    }
    public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        var n=(PropertyDeclarationSyntax)base.VisitPropertyDeclaration(node)!;
        if(Explicit(n.Identifier.Text)) {
            var decoded=Decode(n.Identifier.Text);
            n=n.WithIdentifier(MemberName(decoded)).WithExplicitInterfaceSpecifier(Interface(decoded)).WithModifiers(NoAccess(n.Modifiers));
        }
        if(n.Type is RefTypeSyntax && n.AccessorList!=null) n=n.WithAccessorList(n.AccessorList.WithAccessors(List(n.AccessorList.Accessors.Select(a=>a.Body!=null?a.WithBody(ThrowBody()):a))));
        if(((n.Identifier.Text=="jobWeight" && node.Parent is StructDeclarationSyntax sd && sd.Identifier.Text.EndsWith("ActorAnimationJob")) || (n.Identifier.Text=="HideInInspector" && node.Parent is ClassDeclarationSyntax ac && ac.Identifier.Text=="ParameterAttribute")) && n.AccessorList!=null && !n.AccessorList.Accessors.Any(a=>a.IsKind(SyntaxKind.GetAccessorDeclaration)))
            n=n.WithAccessorList(n.AccessorList.AddAccessors(AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithBody(ThrowBody()).WithLeadingTrivia(Comment("// TODO(qa-recon): Getter stripped from game metadata; required for C# interface/attribute compilation."))));
        if(n.Identifier.Text=="Item" && n.ExplicitInterfaceSpecifier?.Name.ToString()=="System.Collections.IDictionary")
            return IndexerDeclaration(n.Type).WithExplicitInterfaceSpecifier(n.ExplicitInterfaceSpecifier).WithParameterList(BracketedParameterList(SingletonSeparatedList(Parameter(Identifier("key")).WithType(PredefinedType(Token(SyntaxKind.ObjectKeyword)))))).WithAccessorList(n.AccessorList);
        return n;
    }
    public override SyntaxNode? VisitParameterList(ParameterListSyntax node)
    {
        var n=(ParameterListSyntax)base.VisitParameterList(node)!;
        bool required=false;
        var ps=n.Parameters.ToArray();
        for(int i=ps.Length-1;i>=0;i--) {
            var p=ps[i];
            if(p.Default==null && !p.Modifiers.Any(SyntaxKind.ParamsKeyword)) required=true;
            else if(p.Default!=null && required) {
                var opt = Attribute(ParseName("global::System.Runtime.InteropServices.Optional"));
                var val = Attribute(ParseName("global::System.Runtime.InteropServices.DefaultParameterValue"), AttributeArgumentList(SingletonSeparatedList(AttributeArgument(p.Default.Value))));
                var attrs = AttributeList(SeparatedList(new[] { opt, val }));
                ps[i]=p.WithDefault(null).AddAttributeLists(attrs);
            }
        }
        return n.WithParameters(SeparatedList(ps));
    }
    public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
    {
        var n=(StructDeclarationSyntax)base.VisitStructDeclaration(node)!;
        if(n.Identifier.Text.StartsWith("__StaticArrayInitTypeSize")) {
            n=n.WithModifiers(TokenList(Token(SyntaxKind.InternalKeyword)));
            var size=Regex.Match(n.Identifier.Text,@"__StaticArrayInitTypeSize_003D(\d+)");
            if(size.Success) n=n.WithAttributeLists(List(n.AttributeLists.Select(l=>l.WithAttributes(SeparatedList(l.Attributes.Select(a=>a.Name.ToString().EndsWith("StructLayout") && !a.ToString().Contains("Size =") ? a.AddArgumentListArguments(AttributeArgument(LiteralExpression(SyntaxKind.NumericLiteralExpression,Literal(int.Parse(size.Groups[1].Value)))).WithNameEquals(NameEquals("Size"))) : a))))));
        }
        if(n.Identifier.Text=="_003C_003Ec__DisplayClass58_0" && node.Parent is ClassDeclarationSyntax parent && parent.Identifier.Text=="TitanPlayer")
            n=n.WithModifiers(TokenList(Token(SyntaxKind.InternalKeyword))); // ILPP restores original nested-private visibility.
        var operators=n.Members.OfType<OperatorDeclarationSyntax>().ToArray();
        foreach(var op in operators.Where(o=>o.OperatorToken.IsKind(SyntaxKind.EqualsEqualsToken))) {
            if(!operators.Any(o=>o.OperatorToken.IsKind(SyntaxKind.ExclamationEqualsToken)))
                n=n.AddMembers(op.WithOperatorToken(Token(SyntaxKind.ExclamationEqualsToken)).WithLeadingTrivia(Comment("// TODO(qa-recon): Opposite comparison stripped from game; C# requires paired operator declarations.")));
        }
        return n;
    }
    public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
    {
        var n=(FieldDeclarationSyntax)base.VisitFieldDeclaration(node)!;
        var parent=node.Parent as TypeDeclarationSyntax;
        bool explicitLayout=parent?.AttributeLists.ToString().Contains("(LayoutKind)2")==true || parent?.AttributeLists.ToString().Contains("LayoutKind.Explicit")==true;
        if(!explicitLayout) n=n.WithAttributeLists(List(n.AttributeLists.Select(l=>l.WithAttributes(SeparatedList(l.Attributes.Where(a=>!a.Name.ToString().EndsWith("FieldOffset"))))).Where(l=>l.Attributes.Count>0)));
        return n;
    }
    public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
        var n=(ConstructorDeclarationSyntax)base.VisitConstructorDeclaration(node)!;
        if(n.Parent is StructDeclarationSyntax || node.Parent is StructDeclarationSyntax) {
            if(n.Body!=null && !n.Modifiers.Any(SyntaxKind.StaticKeyword)) n=n.WithBody(Block(ParseStatement("this = default;")));
        }
        if(node.Parent is ClassDeclarationSyntax cl && cl.BaseList?.Types.FirstOrDefault()?.Type is TypeSyntax bas && n.Initializer==null && !n.Modifiers.Any(SyntaxKind.StaticKeyword)) {
            var simple=bas is QualifiedNameSyntax q?q.Right:bas;
            var key=simple is GenericNameSyntax gn?gn.Identifier.Text+"`"+gn.TypeArgumentList.Arguments.Count:simple.ToString()+"`0";
            if(baseArities.TryGetValue(key,out var arity) && arity>0) {
                n=n.WithInitializer(ConstructorInitializer(SyntaxKind.BaseConstructorInitializer,ArgumentList(SeparatedList(Enumerable.Range(0,arity).Select(_=>Argument(LiteralExpression(SyntaxKind.DefaultLiteralExpression))))))).WithLeadingTrivia(Comment("// TODO(qa-recon): DummyDll omits base constructor call; default arguments satisfy C# without reconstructing behavior."));
            }
        }
        if(node.Parent is ClassDeclarationSyntax owner && !n.Modifiers.Any(SyntaxKind.StaticKeyword)) {
            if(owner.Identifier.Text=="CampusLoadAsyncSceneParam" && n.ParameterList.Parameters.Count==1)
                n=n.WithInitializer(ConstructorInitializer(SyntaxKind.BaseConstructorInitializer,ArgumentList(SingletonSeparatedList(Argument(DefaultExpression(n.ParameterList.Parameters[0].Type!))))));
            if(owner.Identifier.Text=="CanvasRenderTextureRenderer" && n.Initializer==null)
                n=n.WithInitializer(ConstructorInitializer(SyntaxKind.BaseConstructorInitializer,ArgumentList(SingletonSeparatedList(Argument(DefaultExpression(ParseTypeName("global::UnityEngine.Rendering.Universal.ScriptableRendererData"))))))).WithLeadingTrivia(Comment("// TODO(qa-recon): DummyDll omits base constructor call; placeholder default data, original behavior unknown."));
        }
        return n;
    }
    public static void Run(string path) {
        foreach(var file in Directory.EnumerateFiles(path,"*.cs",SearchOption.AllDirectories)) {
            var tree=CSharpSyntaxTree.ParseText(File.ReadAllText(file));
            File.WriteAllText(file,new Cleaner().Visit(tree.GetRoot())!.NormalizeWhitespace().ToFullString()+"\n");
        }
    }
}
