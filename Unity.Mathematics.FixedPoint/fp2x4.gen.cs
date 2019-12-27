//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics.FixedPoint
{
    [System.Serializable]
    public partial struct fp2x4 : System.IEquatable<fp2x4>, IFormattable
    {
        public fp2 c0;
        public fp2 c1;
        public fp2 c2;
        public fp2 c3;

        /// <summary>fp2x4 zero value.</summary>
        public static readonly fp2x4 zero;

        /// <summary>Constructs a fp2x4 matrix from four fp2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x4(fp2 c0, fp2 c1, fp2 c2, fp2 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a fp2x4 matrix from 8 fp values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x4(fp m00, fp m01, fp m02, fp m03,
                     fp m10, fp m11, fp m12, fp m13)
        { 
            this.c0 = new fp2(m00, m10);
            this.c1 = new fp2(m01, m11);
            this.c2 = new fp2(m02, m12);
            this.c3 = new fp2(m03, m13);
        }

        /// <summary>Constructs a fp2x4 matrix from a single fp value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x4(fp v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a fp2x4 matrix from a single int value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x4(int v)
        {
            this.c0 = (fp2)v;
            this.c1 = (fp2)v;
            this.c2 = (fp2)v;
            this.c3 = (fp2)v;
        }

        /// <summary>Constructs a fp2x4 matrix from a int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x4(int2x4 v)
        {
            this.c0 = (fp2)v.c0;
            this.c1 = (fp2)v.c1;
            this.c2 = (fp2)v.c2;
            this.c3 = (fp2)v.c3;
        }

        /// <summary>Constructs a fp2x4 matrix from a single uint value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x4(uint v)
        {
            this.c0 = (fp2)v;
            this.c1 = (fp2)v;
            this.c2 = (fp2)v;
            this.c3 = (fp2)v;
        }

        /// <summary>Constructs a fp2x4 matrix from a uint2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public fp2x4(uint2x4 v)
        {
            this.c0 = (fp2)v.c0;
            this.c1 = (fp2)v.c1;
            this.c2 = (fp2)v.c2;
            this.c3 = (fp2)v.c3;
        }


        /// <summary>Implicitly converts a single fp value to a fp2x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator fp2x4(fp v) { return new fp2x4(v); }

        /// <summary>Explicitly converts a single int value to a fp2x4 matrix by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp2x4(int v) { return new fp2x4(v); }

        /// <summary>Explicitly converts a int2x4 matrix to a fp2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp2x4(int2x4 v) { return new fp2x4(v); }

        /// <summary>Explicitly converts a single uint value to a fp2x4 matrix by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp2x4(uint v) { return new fp2x4(v); }

        /// <summary>Explicitly converts a uint2x4 matrix to a fp2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator fp2x4(uint2x4 v) { return new fp2x4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator * (fp2x4 lhs, fp2x4 rhs) { return new fp2x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator * (fp2x4 lhs, fp rhs) { return new fp2x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator * (fp lhs, fp2x4 rhs) { return new fp2x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator + (fp2x4 lhs, fp2x4 rhs) { return new fp2x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator + (fp2x4 lhs, fp rhs) { return new fp2x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator + (fp lhs, fp2x4 rhs) { return new fp2x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator - (fp2x4 lhs, fp2x4 rhs) { return new fp2x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator - (fp2x4 lhs, fp rhs) { return new fp2x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator - (fp lhs, fp2x4 rhs) { return new fp2x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator / (fp2x4 lhs, fp2x4 rhs) { return new fp2x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator / (fp2x4 lhs, fp rhs) { return new fp2x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator / (fp lhs, fp2x4 rhs) { return new fp2x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator % (fp2x4 lhs, fp2x4 rhs) { return new fp2x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator % (fp2x4 lhs, fp rhs) { return new fp2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator % (fp lhs, fp2x4 rhs) { return new fp2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise increment operation on a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator ++ (fp2x4 val) { return new fp2x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        /// <summary>Returns the result of a componentwise decrement operation on a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator -- (fp2x4 val) { return new fp2x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (fp2x4 lhs, fp2x4 rhs) { return new bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (fp2x4 lhs, fp rhs) { return new bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (fp lhs, fp2x4 rhs) { return new bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (fp2x4 lhs, fp2x4 rhs) { return new bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (fp2x4 lhs, fp rhs) { return new bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (fp lhs, fp2x4 rhs) { return new bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (fp2x4 lhs, fp2x4 rhs) { return new bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (fp2x4 lhs, fp rhs) { return new bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (fp lhs, fp2x4 rhs) { return new bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (fp2x4 lhs, fp2x4 rhs) { return new bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (fp2x4 lhs, fp rhs) { return new bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (fp lhs, fp2x4 rhs) { return new bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator - (fp2x4 val) { return new fp2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise unary plus operation on a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 operator + (fp2x4 val) { return new fp2x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        /// <summary>Returns the result of a componentwise equality operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (fp2x4 lhs, fp2x4 rhs) { return new bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (fp2x4 lhs, fp rhs) { return new bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (fp lhs, fp2x4 rhs) { return new bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two fp2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (fp2x4 lhs, fp2x4 rhs) { return new bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a fp2x4 matrix and a fp value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (fp2x4 lhs, fp rhs) { return new bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a fp value and a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (fp lhs, fp2x4 rhs) { return new bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }



        /// <summary>Returns the fp2 element at a specified index.</summary>
        unsafe public ref fp2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (fp2x4* array = &this) { return ref ((fp2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the fp2x4 is equal to a given fp2x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(fp2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the fp2x4 is equal to a given fp2x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((fp2x4)o); }


        /// <summary>Returns a hash code for the fp2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)fpmath.hash(this); }


        /// <summary>Returns a string representation of the fp2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("fp2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        /// <summary>Returns a string representation of the fp2x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("fp2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class fpmath
    {
        /// <summary>Returns a fp2x4 matrix constructed from four fp2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 fp2x4(fp2 c0, fp2 c1, fp2 c2, fp2 c3) { return new fp2x4(c0, c1, c2, c3); }

        /// <summary>Returns a fp2x4 matrix constructed from from 8 fp values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 fp2x4(fp m00, fp m01, fp m02, fp m03,
                                  fp m10, fp m11, fp m12, fp m13)
        {
            return new fp2x4(m00, m01, m02, m03,
                             m10, m11, m12, m13);
        }

        /// <summary>Returns a fp2x4 matrix constructed from a single fp value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 fp2x4(fp v) { return new fp2x4(v); }

        /// <summary>Returns a fp2x4 matrix constructed from a single int value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 fp2x4(int v) { return new fp2x4(v); }

        /// <summary>Return a fp2x4 matrix constructed from a int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 fp2x4(int2x4 v) { return new fp2x4(v); }

        /// <summary>Returns a fp2x4 matrix constructed from a single uint value by converting it to fp and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 fp2x4(uint v) { return new fp2x4(v); }

        /// <summary>Return a fp2x4 matrix constructed from a uint2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp2x4 fp2x4(uint2x4 v) { return new fp2x4(v); }

        /// <summary>Return the fp4x2 transpose of a fp2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static fp4x2 transpose(fp2x4 v)
        {
            return fp4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        /// <summary>Returns a uint hash code of a fp2x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(fp2x4 v)
        {
            return math.csum(fpmath.asuint(v.c0) * uint2(0xA1E92D39u, 0x4583C801u) + 
                        fpmath.asuint(v.c1) * uint2(0x9536A0F5u, 0xAF816615u) + 
                        fpmath.asuint(v.c2) * uint2(0x9AF8D62Du, 0xE3600729u) + 
                        fpmath.asuint(v.c3) * uint2(0x5F17300Du, 0x670D6809u)) + 0x7AF32C49u;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a fp2x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(fp2x4 v)
        {
            return (fpmath.asuint(v.c0) * uint2(0xAE131389u, 0x5D1B165Bu) + 
                    fpmath.asuint(v.c1) * uint2(0x87096CD7u, 0x4C7F6DD1u) + 
                    fpmath.asuint(v.c2) * uint2(0x4822A3E9u, 0xAAC3C25Du) + 
                    fpmath.asuint(v.c3) * uint2(0xD21D0945u, 0x88FCAB2Du)) + 0x614DA60Du;
        }

    }
}
