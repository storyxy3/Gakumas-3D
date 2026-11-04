using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
public static class LiveBuild
{
    public static void BuildLinux()
    {
        BuildStandalone(BuildTarget.StandaloneLinux64, "Build/Linux/TrueEnd.x86_64");
    }

    public static void BuildWindows()
    {
        BuildStandalone(BuildTarget.StandaloneWindows64, "Build/Windows/TrueEnd.exe");
    }

    private static void BuildStandalone(BuildTarget target, string destination)
    {
        PlayerSettings.SetScriptingBackend(NamedBuildTarget.Standalone,
            target == BuildTarget.StandaloneWindows64 ? ScriptingImplementation.IL2CPP : ScriptingImplementation.Mono2x);
        if (target == BuildTarget.StandaloneWindows64)
        {
            PlayerSettings.SetIl2CppCompilerConfiguration(NamedBuildTarget.Standalone, Il2CppCompilerConfiguration.Release);
            PlayerSettings.SetManagedStrippingLevel(NamedBuildTarget.Standalone, ManagedStrippingLevel.Minimal);
            PlayerSettings.SetUseDefaultGraphicsAPIs(target, false);
            PlayerSettings.SetGraphicsAPIs(target, new[] { UnityEngine.Rendering.GraphicsDeviceType.Direct3D11 });
        }
        else
        {
            PlayerSettings.SetUseDefaultGraphicsAPIs(target, false);
            PlayerSettings.SetGraphicsAPIs(target, new[] { UnityEngine.Rendering.GraphicsDeviceType.Vulkan, UnityEngine.Rendering.GraphicsDeviceType.OpenGLCore });
        }
        Directory.CreateDirectory(Path.GetDirectoryName(destination));
        var result = BuildPipeline.BuildPlayer(new[] { "Assets/Main.unity" }, destination, target, BuildOptions.None);
        Debug.Log("LIVE_BUILD " + result.summary.result + " errors=" + result.summary.totalErrors);
        if (result.summary.result != UnityEditor.Build.Reporting.BuildResult.Succeeded)
            throw new BuildFailedException("Standalone player build failed.");
    }

    public static void BuildAndroid()
    {
        PlayerSettings.SetScriptingBackend(NamedBuildTarget.Android, ScriptingImplementation.IL2CPP);
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;
        PlayerSettings.SetManagedStrippingLevel(NamedBuildTarget.Android, ManagedStrippingLevel.Minimal);
        PlayerSettings.SetIl2CppCompilerConfiguration(NamedBuildTarget.Android, Il2CppCompilerConfiguration.Release);
        EditorUserBuildSettings.androidCreateSymbols = AndroidCreateSymbols.Debugging;
        Directory.CreateDirectory("Build");
        var result = BuildPipeline.BuildPlayer(new[] { "Assets/Main.unity" }, "Build/live.apk", BuildTarget.Android, BuildOptions.None);
        Debug.Log("LIVE_BUILD " + result.summary.result + " errors=" + result.summary.totalErrors);
    }
}
