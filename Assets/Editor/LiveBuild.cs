using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
public static class LiveBuild
{
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
