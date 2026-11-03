namespace Qua.Base
{
    using global::System.Diagnostics;
    using global::Qua.Base;
    using global::UnityEngine;

    public static class HapticFeedback
    {
        public enum Power : byte
        {
            SuperLight = 100,
            Light = 0,
            Medium = 1,
            Heavy = 2
        }

        private interface IGenerator
        {
            void Generate(Power power);
        }

        public class AndroidGenerator : IGenerator
        {
            private static AndroidJavaObject _vibratorService;
            void Qua.Base.HapticFeedback.IGenerator.Generate(Power power)
            {
            }

            [Conditional("UNITY_PLAYER")]
            public static void Vibrate(long milliseconds = 20L, int amplitude = -1)
            {
            }

            private static AndroidJavaObject GetVibratorService()
            {
                return null;
            }

            private static AndroidJavaObject CreateVibrationEffect(long milliseconds, int amplitude)
            {
                return null;
            }

            public AndroidGenerator()
            {
            }
        }

        private static readonly IGenerator _generator;
        static HapticFeedback()
        {
        }

        public static void Generate(Power power)
        {
        }
    }
}
