namespace VLB
{
    using global::System;
    using global::System.Runtime.CompilerServices;
    using global::Unity.Collections;
    using global::Unity.Jobs;
    using global::UnityEngine;
    using global::UnityEngine.Jobs;

    internal abstract class Chunk : IDisposable
    {
        [CompilerGenerated]
        private int _003Ccount_003Ek__BackingField;
        [CompilerGenerated]
        private int _003Ccapacity_003Ek__BackingField;
        [CompilerGenerated]
        private JobHandle _003CcurrentJobHandle_003Ek__BackingField;
        public int count
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        public int capacity
        {
            [CompilerGenerated]
            get
            {
                return default(int);
            }

            [CompilerGenerated]
            protected set
            {
            }
        }

        public JobHandle currentJobHandle
        {
            [CompilerGenerated]
            get
            {
                return default(JobHandle);
            }

            [CompilerGenerated]
            set
            {
            }
        }

        public virtual void Push()
        {
        }

        public abstract void RemoveAtSwapBack(int index);
        public abstract void SetCapacity(int capacity);
        public abstract void Dispose();
        protected void ResizeArray<T>(ref T[] array, int capacity)
        {
        }

        protected void ResizeArray<T>(ref NativeArray<T> array, int capacity)
            where T : struct
        {
        }

        protected void ResizeNativeArray<T>(ref TransformAccessArray array, T[] components, int capacity)
            where T : Component
        {
        }

        protected void RemoveAtSwapBack<T>(ref NativeArray<T> array, int index, int count)
            where T : struct
        {
        }

        protected void RemoveAtSwapBack<T>(ref T[] array, int index, int count)
        {
        }

        protected Chunk()
        {
        }
    }
}
