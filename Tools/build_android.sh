#!/usr/bin/env bash
set -eu
cd "$(dirname "$0")/.."
ulimit -n 65536
mkdir -p .recon
xvfb-run -a -s '-screen 0 1280x720x24' /data/xy/.toolchains/unity-6000.0.77f1/Editor/Unity -batchmode -force-glcore -quit -buildTarget Android -projectPath "$PWD" -executeMethod LiveBuild.BuildAndroid -logFile "$PWD/.recon/build.log" > "$PWD/.recon/build-console.log" 2>&1
