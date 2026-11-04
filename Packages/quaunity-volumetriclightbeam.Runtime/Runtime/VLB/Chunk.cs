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
                return _003Ccount_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003Ccount_003Ek__BackingField = value;
            }
        }

        public int capacity
        {
            [CompilerGenerated]
            get
            {
                return _003Ccapacity_003Ek__BackingField;
            }

            [CompilerGenerated]
            protected set
            {
                _003Ccapacity_003Ek__BackingField = value;
            }
        }

        public JobHandle currentJobHandle
        {
            [CompilerGenerated]
            get
            {
                return _003CcurrentJobHandle_003Ek__BackingField;
            }

            [CompilerGenerated]
            set
            {
                _003CcurrentJobHandle_003Ek__BackingField = value;
            }
        }

        public virtual void Push()
        {
            count++;
        }

        public abstract void RemoveAtSwapBack(int index);
        public abstract void SetCapacity(int capacity);
        public abstract void Dispose();
        protected void ResizeArray<T>(ref T[] array, int capacity)
        {
            if (array == null) array = new T[capacity];
            else Array.Resize(ref array, capacity);
        }

        protected void ResizeArray<T>(ref NativeArray<T> array, int capacity)
            where T : struct
        {
            var resized = new NativeArray<T>(capacity, Allocator.Persistent, NativeArrayOptions.UninitializedMemory);
            if (array.IsCreated)
            {
                NativeArray<T>.Copy(array, resized, array.Length);
                array.Dispose();
            }
            array = resized;
        }

        protected void ResizeNativeArray<T>(ref TransformAccessArray array, T[] components, int capacity)
            where T : Component
        {
            var resized = new TransformAccessArray(capacity);
            if (array.isCreated)
            {
                for (int i = 0; i < array.length; i++) resized.Add(components[i].transform);
                array.Dispose();
            }
            array = resized;
        }

        protected void RemoveAtSwapBack<T>(ref NativeArray<T> array, int index, int count)
            where T : struct
        {
            array[index] = array[count - 1];
        }

        protected void RemoveAtSwapBack<T>(ref T[] array, int index, int count)
        {
            array[index] = array[count - 1];
        }

        protected Chunk()
        {
        }
    }
}
