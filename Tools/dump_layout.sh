#!/usr/bin/env bash
# Build artifact comparison only; this does not run game code.
set -eu
cd "$(dirname "$0")/.."
project_root="$PWD"
native_root="$project_root/Library/Bee/Android/Prj/IL2CPP/Gradle/unityLibrary/src/main"
mkdir -p .recon/live-dump
DOTNET_ROOT=/data/xy/.toolchains/dotnet-8 DOTNET_ROLL_FORWARD=Major /data/xy/.toolchains/dotnet-8/dotnet /data/xy/gakumas/tools/il2cppdumper/Il2CppDumper.dll "$native_root/jniLibs/arm64-v8a/libil2cpp.so" "$native_root/assets/bin/Data/Managed/Metadata/global-metadata.dat" "$project_root/.recon/live-dump" > "$project_root/.recon/dumper.log" 2>&1
python3 Tools/report_layout.py
