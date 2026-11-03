namespace Octo.Util
{
    using global::System.Diagnostics;
    using global::UnityEngine;

    internal class Timer : MonoBehaviour
    {
        private Stopwatch sinceStartupTimer;
        public long sinceStartupMilliseconds
        {
            get
            {
                return default(long);
            }
        }

        public float sinceStartup
        {
            get
            {
                return default(float);
            }
        }

        private void Awake()
        {
        }

        private void OnApplicationPause(bool isPause)
        {
        }

        public Timer()
        {
        }
    }
}
