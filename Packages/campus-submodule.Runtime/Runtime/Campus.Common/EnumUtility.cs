namespace Campus.Common
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Runtime.CompilerServices;
    using global::System.Runtime.InteropServices;
    using global::Campus.Common;

    public static class EnumUtility
    {
        private static class StringUtility
        {
            [ThreadStatic]
            private static char[] _sharedCharaBuffer;
            public static string FastToLower(string s)
            {
                return null;
            }
        }

        private enum EnumCastType
        {
            Unknown,
            Short,
            Int,
            Long,
            Ulong
        }

        private static class CachedEnumValue<T>
            where T : struct, IComparable, IConvertible, IFormattable
        {
            [Serializable]
            [CompilerGenerated]
            private sealed class _003C_003Ec
            {
                public static readonly _003C_003Ec _003C_003E9;
                public static Func<object, object> _003C_003E9__28_0;
                public _003C_003Ec()
                {
                }

                internal object _003Cget_ObjectToEnumValue_003Eb__28_0(object value)
                {
                    return null;
                }
            }

            public static readonly T[] Values;
            private static string[] _names;
            private static string[] _lowerNames;
            private static Dictionary<string, int> _namesToIndex;
            private static Dictionary<string, int> _lowerNamesToIndex;
            private static Dictionary<T, string> _enumToName;
            private static Dictionary<T, string> _enumToLowerName;
            public static readonly TypeCode Code;
            public static readonly EnumCastType CastType;
            private static Dictionary<object, T> _genericValueToEnumValue;
            private static Dictionary<int, T> _intToValue;
            private static Dictionary<long, T> _longToValue;
            public static string[] Names
            {
                get
                {
                    return null;
                }
            }

            public static string[] LowerNames
            {
                get
                {
                    return null;
                }
            }

            public static Dictionary<T, string> EnumToName
            {
                get
                {
                    return null;
                }
            }

            public static Dictionary<T, string> EnumToLowerName
            {
                get
                {
                    return null;
                }
            }

            public static Dictionary<object, T> ObjectToEnumValue
            {
                get
                {
                    return null;
                }
            }

            public static Dictionary<int, T> IntToValue
            {
                get
                {
                    return null;
                }
            }

            public static Dictionary<long, T> LongToValue
            {
                get
                {
                    return null;
                }
            }

            private static Dictionary<TValueType, T> CreateValueDictionary<TValueType>(Func<object, TValueType> func, [Optional] IEqualityComparer<TValueType> equalityComparer)
            {
                return null;
            }

            static CachedEnumValue()
            {
            }

            public static bool TryGetValueByLowerName(string valueName, out T value)
            {
                throw null;
            }

            public static bool TryGetValueByName(string valueName, out T value)
            {
                throw null;
            }

            private static bool TryGetValue(string name, string[] names, ref Dictionary<string, int> map, out T result)
            {
                throw null;
            }
        }

        private class IntComparer : IEqualityComparer<int>
        {
            public bool Equals(int x, int y)
            {
                return default(bool);
            }

            public int GetHashCode(int obj)
            {
                return default(int);
            }

            public IntComparer()
            {
            }
        }

        private class NumericComparer : IEqualityComparer<object>
        {
            public new bool Equals(object x, object y)
            {
                return default(bool);
            }

            public int GetHashCode(object obj)
            {
                return default(int);
            }

            public NumericComparer()
            {
            }
        }

        public static string GetName<TEnum>(TEnum value)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return null;
        }

        public static string GetLowerName<TEnum>(TEnum value)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return null;
        }

        public static TEnum ParseOrDefault<TEnum>(string valueName)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(TEnum);
        }

        public static TEnum ParseOrDefault<TEnum>(int value)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(TEnum);
        }

        public static TEnum ParseOrDefault<TEnum>(long value)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(TEnum);
        }

        public static TEnum ParseOrDefault<TEnum>(string valueName, TEnum defaultValue)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(TEnum);
        }

        public static TEnum ParseOrDefault<TEnum>(int value, TEnum defaultValue)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(TEnum);
        }

        public static TEnum ParseOrDefault<TEnum>(long value, TEnum defaultValue)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(TEnum);
        }

        public static bool TryParse<TEnum>(string valueName, out TEnum outValue)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            throw null;
        }

        public static bool TryParse<TEnum>(string valueName, bool ignoreCase, out TEnum outValue)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            throw null;
        }

        public static string[] Names<TEnum>()
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return null;
        }

        public static TEnum[] Values<TEnum>()
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return null;
        }

        public static int Count<TEnum>()
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(int);
        }

        public static int Count<TEnum>(Func<TEnum, bool> predicate)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(int);
        }

        public static TEnum Default<TEnum>()
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(TEnum);
        }

        public static TEnum Next<TEnum>(TEnum current)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(TEnum);
        }

        public static TEnum Prev<TEnum>(TEnum current)
            where TEnum : struct, IComparable, IConvertible, IFormattable
        {
            return default(TEnum);
        }
    }
}
