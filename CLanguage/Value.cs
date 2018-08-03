﻿using System;
using System.Runtime.InteropServices;

namespace CLanguage
{
    [StructLayout (LayoutKind.Explicit, Size = 8)]
    public struct Value
    {
        [FieldOffset (0)]
        public System.Double Float64Value;
        [FieldOffset (0)]
        public System.Int64 Int64Value;
        [FieldOffset (0)]
        public System.Single Float32Value;
        [FieldOffset (0)]
        public System.Int32 Int32Value;
        [FieldOffset (0)]
        public System.Int32 PointerValue;

        public override string ToString ()
        {
            return Int32Value.ToString ();
        }

        public static implicit operator Value (float v)
        {
            return new Value {
                Float32Value = v,
            };
        }

        public static implicit operator Value (double v)
        {
            return new Value {
                Float64Value = v,
            };
        }

        public static implicit operator Value (ulong v)
        {
            return new Value {
                Int64Value = (long)v,
            };
        }

        public static implicit operator Value (long v)
        {
            return new Value {
                Int64Value = v,
            };
        }

        public static implicit operator Value (uint v)
        {
            return new Value {
                Int32Value = (int)v,
            };
        }

        public static implicit operator Value (int v)
        {
            return new Value {
                Int32Value = v,
            };
        }

        public static implicit operator Value (ushort v)
        {
            return new Value {
                Int32Value = v,
            };
        }

        public static implicit operator Value (short v)
        {
            return new Value {
                Int32Value = v,
            };
        }

        public static implicit operator Value (byte v)
        {
            return new Value {
                Int32Value = v,
            };
        }

        public static implicit operator Value (sbyte v)
        {
            return new Value {
                Int32Value = v,
            };
        }
        /*
        public static implicit operator float (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return (float)v.Int32Value;
                case ValueType.Int64:
                    return (float)v.Int64Value;
                case ValueType.Float32:
                    return (float)v.Float32Value;
                case ValueType.Float64:
                    return (float)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return (float)v.PointerValue;
                default:
                    return 0;
            }
        }

        public static implicit operator double (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return (double)v.Int32Value;
                case ValueType.Int64:
                    return (double)v.Int64Value;
                case ValueType.Float32:
                    return (double)v.Float32Value;
                case ValueType.Float64:
                    return (double)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return (double)v.PointerValue;
                default:
                    return 0;
            }
        }

        public static implicit operator ulong (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return (ulong)v.Int32Value;
                case ValueType.Int64:
                    return (ulong)v.Int64Value;
                case ValueType.Float32:
                    return (ulong)v.Float32Value;
                case ValueType.Float64:
                    return (ulong)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return (ulong)v.PointerValue;
                default:
                    return 0;
            }
        }

        public static implicit operator long (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return (long)v.Int32Value;
                case ValueType.Int64:
                    return (long)v.Int64Value;
                case ValueType.Float32:
                    return (long)v.Float32Value;
                case ValueType.Float64:
                    return (long)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return (long)v.PointerValue;
                default:
                    return 0;
            }
        }

        public static implicit operator uint (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return (uint)v.Int32Value;
                case ValueType.Int64:
                    return (uint)v.Int64Value;
                case ValueType.Float32:
                    return (uint)v.Float32Value;
                case ValueType.Float64:
                    return (uint)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return (uint)v.PointerValue;
                default:
                    return 0;
            }
        }

        public static implicit operator int (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return v.Int32Value;
                case ValueType.Int64:
                    return (int)v.Int64Value;
                case ValueType.Float32:
                    return (int)v.Float32Value;
                case ValueType.Float64:
                    return (int)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return v.PointerValue;
                default:
                    return 0;
            }
        }

        public static implicit operator ushort (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return (ushort)v.Int32Value;
                case ValueType.Int64:
                    return (ushort)v.Int64Value;
                case ValueType.Float32:
                    return (ushort)v.Float32Value;
                case ValueType.Float64:
                    return (ushort)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return (ushort)v.PointerValue;
                default:
                    return 0;
            }
        }

        public static implicit operator short (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return (short)v.Int32Value;
                case ValueType.Int64:
                    return (short)v.Int64Value;
                case ValueType.Float32:
                    return (short)v.Float32Value;
                case ValueType.Float64:
                    return (short)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return (short)v.PointerValue;
                default:
                    return 0;
            }
        }

        public static implicit operator byte (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return (byte)v.Int32Value;
                case ValueType.Int64:
                    return (byte)v.Int64Value;
                case ValueType.Float32:
                    return (byte)v.Float32Value;
                case ValueType.Float64:
                    return (byte)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return (byte)v.PointerValue;
                default:
                    return 0;
            }
        }

        public static implicit operator sbyte (Value v)
        {
            switch (v.Type) {
                case ValueType.Int32:
                    return (sbyte)v.Int32Value;
                case ValueType.Int64:
                    return (sbyte)v.Int64Value;
                case ValueType.Float32:
                    return (sbyte)v.Float32Value;
                case ValueType.Float64:
                    return (sbyte)v.Float64Value;
                case ValueType.FunctionPointer:
                case ValueType.GlobalPointer:
                case ValueType.ArgPointer:
                case ValueType.LocalPointer:
                    return (sbyte)v.PointerValue;
                default:
                    return 0;
            }
        }
        */

        public static Value FunctionPointer (int index, int offset = 0) => new Value {
            PointerValue = index + offset,
        };
        public static Value GlobalPointer (int index, int offset = 0) => new Value {
            PointerValue = index + offset,
        };
        public static Value ArgPointer (int index, int offset = 0) => new Value {
            PointerValue = index + offset,
        };
        public static Value LocalPointer (int index, int offset = 0) => new Value {
            PointerValue = index + offset,
        };
    }
}
