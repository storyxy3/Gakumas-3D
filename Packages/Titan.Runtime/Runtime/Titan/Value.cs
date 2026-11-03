namespace Titan
{
    using global::System;
    using global::Titan;

    public abstract class Value : IDisposable
    {
        public static readonly Value Null;
        public abstract Titan.ValueType Type { get; }

        public bool IsNull
        {
            get
            {
                return default(bool);
            }
        }

        public virtual float GetNumber()
        {
            return default(float);
        }

        public virtual int GetInteger()
        {
            return default(int);
        }

        public virtual bool GetBool()
        {
            return default(bool);
        }

        public virtual string GetString()
        {
            return null;
        }

        public abstract object GetObject();
        public T GetObject<T>()
        {
            return default(T);
        }

        public abstract void Dispose();
        public static Value GetOrCreate(float value)
        {
            return null;
        }

        public static Value GetOrCreate(int value)
        {
            return null;
        }

        public static Value GetOrCreate(bool value)
        {
            return null;
        }

        public static Value GetOrCreate(string value)
        {
            return null;
        }

        public static Value GetOrCreate(object value)
        {
            return null;
        }

        public static Value GetOrCreate(Callable callable)
        {
            return null;
        }

        public static implicit operator float (Value value)
        {
            return default(float);
        }

        public static implicit operator int (Value value)
        {
            return default(int);
        }

        public static implicit operator bool (Value value)
        {
            return default(bool);
        }

        public static implicit operator string (Value value)
        {
            return null;
        }

        public static Value operator +(Value rhs)
        {
            return null;
        }

        public static Value operator -(Value rhs)
        {
            return null;
        }

        public static Value operator !(Value rhs)
        {
            return null;
        }

        public static Value operator +(Value lhs, Value rhs)
        {
            return null;
        }

        public static Value operator -(Value lhs, Value rhs)
        {
            return null;
        }

        public static Value operator *(Value lhs, Value rhs)
        {
            return null;
        }

        public static Value operator /(Value lhs, Value rhs)
        {
            return null;
        }

        public static Value IntegerDivision(Value lhs, Value rhs)
        {
            return null;
        }

        public static Value operator %(Value lhs, Value rhs)
        {
            return null;
        }

        public static Value operator <(Value lhs, Value rhs)
        {
            return null;
        }

        public static Value operator <=(Value lhs, Value rhs)
        {
            return null;
        }

        public static Value operator>(Value lhs, Value rhs)
        {
            return null;
        }

        public static Value operator >=(Value lhs, Value rhs)
        {
            return null;
        }

        public static bool Equals(Value lhs, Value rhs)
        {
            return default(bool);
        }

        private static Titan.ValueType GetOperationType(Value lhs, Value rhs)
        {
            return default(Titan.ValueType);
        }

        protected Value()
        {
        }
    }
}
