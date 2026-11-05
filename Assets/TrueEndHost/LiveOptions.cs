using System;
using System.Globalization;
using System.IO;
using System.Linq;
using UnityEngine;

namespace TrueEnd.Host
{
    internal sealed class LiveOptions
    {
        public string DataDirectory = Path.Combine(Application.streamingAssetsPath, "ttmr001");
        public string CaptureDirectory = Path.GetFullPath("captures");
        public string PoseLog;
        public int CaptureFps;
        public double StopTime = double.PositiveInfinity;
        public double StartTime;
        public double QuitAfter = double.PositiveInfinity;
        public double[] ScreenshotTimes = Array.Empty<double>();
        public bool QuitAtEnd;
        public bool Mute = Application.platform == RuntimePlatform.LinuxPlayer;

        public static LiveOptions Parse(string[] arguments)
        {
            var options = new LiveOptions();
            for (int i = 1; i < arguments.Length; i++)
            {
                string argument = arguments[i];
                switch (argument)
                {
                    case "--sample":
                        if (Value(arguments, ref i) != "ttmr001")
                            throw new ArgumentException("The available sample is ttmr001.");
                        break;
                    case "--data": options.DataDirectory = Path.GetFullPath(Value(arguments, ref i)); break;
                    case "--capture-dir": options.CaptureDirectory = Path.GetFullPath(Value(arguments, ref i)); break;
                    case "--pose-log": options.PoseLog = Path.GetFullPath(Value(arguments, ref i)); break;
                    case "--capture-fps":
                        options.CaptureFps = int.Parse(Value(arguments, ref i), CultureInfo.InvariantCulture);
                        if (options.CaptureFps < 1 || options.CaptureFps > 240)
                            throw new ArgumentException("Capture FPS must be between 1 and 240.");
                        break;
                    case "--stop-time": options.StopTime = Seconds(Value(arguments, ref i)); options.QuitAtEnd = true; break;
                    case "--start-time": options.StartTime = Seconds(Value(arguments, ref i)); break;
                    case "--quit-after": options.QuitAfter = Seconds(Value(arguments, ref i)); break;
                    case "--quit-at-end": options.QuitAtEnd = true; break;
                    case "--screenshots":
                        options.QuitAtEnd = true;
                        options.ScreenshotTimes = Value(arguments, ref i).Split(',').Select(Seconds).Distinct().OrderBy(t => t).ToArray();
                        break;
                    case "--mute": options.Mute = true; break;
                    default:
                        if (argument.StartsWith("--", StringComparison.Ordinal))
                            throw new ArgumentException("Unknown live option " + argument);
                        break;
                }
            }
            if (options.StopTime <= options.StartTime)
                throw new ArgumentException("Stop time must be after start time.");
            return options;
        }

        private static string Value(string[] arguments, ref int index)
        {
            if (++index == arguments.Length)
                throw new ArgumentException("Missing value for " + arguments[index - 1]);
            return arguments[index];
        }

        private static double Seconds(string value)
        {
            double seconds = double.Parse(value, CultureInfo.InvariantCulture);
            if (double.IsNaN(seconds) || double.IsInfinity(seconds) || seconds < 0)
                throw new ArgumentException("Time must be a finite nonnegative number.");
            return seconds;
        }
    }
}
