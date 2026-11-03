namespace Cysharp.Threading.Tasks
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::UnityEngine.Networking;

    public class UnityWebRequestException : Exception
    {
        [CompilerGenerated]
        private readonly UnityWebRequest _003CUnityWebRequest_003Ek__BackingField;
        [CompilerGenerated]
        private readonly UnityWebRequest.Result _003CResult_003Ek__BackingField;
        [CompilerGenerated]
        private readonly string _003CError_003Ek__BackingField;
        [CompilerGenerated]
        private readonly string _003CText_003Ek__BackingField;
        [CompilerGenerated]
        private readonly long _003CResponseCode_003Ek__BackingField;
        [CompilerGenerated]
        private readonly Dictionary<string, string> _003CResponseHeaders_003Ek__BackingField;
        private string msg;
        public UnityWebRequest UnityWebRequest
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public string Error
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public string Text
        {
            [CompilerGenerated]
            get
            {
                return null;
            }
        }

        public long ResponseCode
        {
            [CompilerGenerated]
            get
            {
                return default(long);
            }
        }

        public override string Message
        {
            get
            {
                return null;
            }
        }

        public UnityWebRequestException(UnityWebRequest unityWebRequest)
        {
        }
    }
}
