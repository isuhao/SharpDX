﻿// Copyright (c) 2010-2011 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.using System;
using System.Runtime.InteropServices;
using SharpDX;

namespace SharpDX.Direct2D1
{
    /// <summary>
    /// Direct2D Matrix 3x2. Use <see cref="SharpDX.Matrix"/> and explicit cast to <see cref="Matrix3x2"/>.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix3x2
    {
        /// <summary>
        /// Element (1,1)
        /// </summary>
        public float M11;

        /// <summary>
        /// Element (1,2)
        /// </summary>
        public float M12;

        /// <summary>
        /// Element (2,1)
        /// </summary>
        public float M21;

        /// <summary>
        /// Element (2,2)
        /// </summary>
        public float M22;

        /// <summary>
        /// Element (3,1)
        /// </summary>
        public float M31;

        /// <summary>
        /// Element (3,2)
        /// </summary>
        public float M32;

        /// <summary>
        /// Performs an explicit conversion from <see cref="SharpDX.Matrix"/> to <see cref="SharpDX.Direct2D1.Matrix3x2"/>.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator Matrix3x2(Matrix matrix)
        {
            Matrix3x2 result = new Matrix3x2();

            result.M11 = matrix.M11;
            result.M12 = matrix.M12;
            result.M21 = matrix.M21;
            result.M22 = matrix.M22;
            result.M31 = matrix.M41;
            result.M32 = matrix.M42;
            return result;
        }

        /// <summary>
        /// Gets the identity matrix.
        /// </summary>
        /// <value>The identity matrix.</value>
        public static Matrix3x2 Identity
        {
            get
            {
                Matrix3x2 result = new Matrix3x2();
                result.M11 = 1f;
                result.M22 = 1f;
                return result;
            }
        }
    }
 
}
