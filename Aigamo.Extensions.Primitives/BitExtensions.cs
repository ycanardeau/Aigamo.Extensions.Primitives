using System.Runtime.CompilerServices;

namespace Aigamo.Extensions.Primitives
{
	public static class BitExtensions
	{
		/// <summary>
		/// Retrieves the low-order byte from the given 16-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the low-order byte of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static byte LowByte(this ushort value) => (byte)value;

		/// <summary>
		/// Retrieves the low-order byte from the given 16-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the low-order byte of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static byte LowByte(this short value) => LowByte((ushort)value);

		/// <summary>
		/// Retrieves the low-order 16-bit unsigned integer from the given 32-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the low-order 16-bit unsigned integer of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ushort LowUInt16(this uint value) => (ushort)value;

		/// <summary>
		/// Retrieves the low-order 16-bit unsigned integer from the given 32-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the low-order 16-bit unsigned integer of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ushort LowUInt16(this int value) => LowUInt16((uint)value);

		/// <summary>
		/// Retrieves the low-order 32-bit unsigned integer from the given 64-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the low-order 32-bit unsigned integer of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static uint LowUInt32(this ulong value) => (uint)value;

		/// <summary>
		/// Retrieves the low-order 32-bit unsigned integer from the given 64-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the low-order 32-bit unsigned integer of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static uint LowUInt32(this long value) => LowUInt32((ulong)value);

		/// <summary>
		/// Retrieves the high-order byte from the given 16-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the high-order byte of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static byte HighByte(this ushort value) => (byte)(value >> 8);

		/// <summary>
		/// Retrieves the high-order byte from the given 16-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the high-order byte of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static byte HighByte(this short value) => HighByte((ushort)value);

		/// <summary>
		/// Retrieves the high-order 16-bit unsigned integer from the given 32-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the high-order 16-bit unsigned integer of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ushort HighUInt16(this uint value) => (ushort)(value >> 16);

		/// <summary>
		/// Retrieves the high-order 16-bit unsigned integer from the given 32-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the high-order 16-bit unsigned integer of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ushort HighUInt16(this int value) => HighUInt16((uint)value);

		/// <summary>
		/// Retrieves the high-order 32-bit unsigned integer from the given 64-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the high-order 32-bit unsigned integer of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static uint HighUInt32(this ulong value) => (uint)(value >> 32);

		/// <summary>
		/// Retrieves the high-order 32-bit unsigned integer from the given 64-bit value.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is the high-order 32-bit unsigned integer of the specified value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static uint HighUInt32(this long value) => HighUInt32((ulong)value);

		/// <summary>
		/// Joins two byte values and creates a 16-bit unsigned integer value.
		/// </summary>
		/// <param name="value">The higher part value to be joined.</param>
		/// <param name="low">The lower part value to be joined.</param>
		/// <returns>return value is a 16-bit unsigned integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ushort WithLowByte(this ushort value, byte low) => (low, value.HighByte()).ToUInt16();

		/// <summary>
		/// Joins two byte values and creates a 16-bit signed integer value.
		/// </summary>
		/// <param name="value">The higher part value to be joined.</param>
		/// <param name="low">The lower part value to be joined.</param>
		/// <returns>return value is a 16-bit signed integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static short WithLowByte(this short value, byte low) => (short)WithLowByte((ushort)value, low);

		/// <summary>
		/// Joins two 16-bit unsigned integer values and creates a 32-bit unsigned integer value.
		/// </summary>
		/// <param name="value">The higher part value to be joined.</param>
		/// <param name="low">The lower part value to be joined.</param>
		/// <returns>return value is a 32-bit unsigned integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static uint WithLowUInt16(this uint value, ushort low) => (low, value.HighUInt16()).ToUInt32();

		/// <summary>
		/// Joins two 16-bit unsigned integer values and creates a 32-bit signed integer value.
		/// </summary>
		/// <param name="value">The higher part value to be joined.</param>
		/// <param name="low">The lower part value to be joined.</param>
		/// <returns>return value is a 32-bit signed integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static int WithLowUInt16(this int value, ushort low) => (int)WithLowUInt16((uint)value, low);

		/// <summary>
		/// Joins two 32-bit unsigned integer values and creates a 64-bit unsigned integer value.
		/// </summary>
		/// <param name="value">The higher part value to be joined.</param>
		/// <param name="low">The lower part value to be joined.</param>
		/// <returns>return value is a 64-bit unsigned integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ulong WithLowUInt32(this ulong value, uint low) => (low, value.HighUInt32()).ToUInt64();

		/// <summary>
		/// Joins two 32-bit unsigned integer values and creates a 64-bit signed integer value.
		/// </summary>
		/// <param name="value">The higher part value to be joined.</param>
		/// <param name="low">The lower part value to be joined.</param>
		/// <returns>return value is a 64-bit signed integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static long WithLowUInt32(this long value, uint low) => (long)WithLowUInt32((ulong)value, low);

		/// <summary>
		/// Joins two byte values and creates a 16-bit unsigned integer value.
		/// </summary>
		/// <param name="value">The lower part value to be joined.</param>
		/// <param name="high">The higher part value to be joined.</param>
		/// <returns>return value is a 16-bit unsigned integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ushort WithHighByte(this ushort value, byte high) => (value.LowByte(), high).ToUInt16();

		/// <summary>
		/// Joins two byte values and creates a 16-bit signed integer value.
		/// </summary>
		/// <param name="value">The lower part value to be joined.</param>
		/// <param name="high">The higher part value to be joined.</param>
		/// <returns>return value is a 16-bit signed integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static short WithHighByte(this short value, byte high) => (short)WithHighByte((ushort)value, high);

		/// <summary>
		/// Joins two 16-bit unsigned integer values and creates a 32-bit unsigned integer value.
		/// </summary>
		/// <param name="value">The lower part value to be joined.</param>
		/// <param name="high">The higher part value to be joined.</param>
		/// <returns>return value is a 32-bit unsigned integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static uint WithHighUInt16(this uint value, ushort high) => (value.LowUInt16(), high).ToUInt32();

		/// <summary>
		/// Joins two 16-bit unsigned integer values and creates a 32-bit signed integer value.
		/// </summary>
		/// <param name="value">The lower part value to be joined.</param>
		/// <param name="high">The higher part value to be joined.</param>
		/// <returns>return value is a 32-bit signed integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static int WithHighUInt16(this int value, ushort high) => (int)WithHighUInt16((uint)value, high);

		/// <summary>
		/// Joins two 32-bit unsigned integer values and creates a 64-bit unsigned integer value.
		/// </summary>
		/// <param name="value">The lower part value to be joined.</param>
		/// <param name="high">The higher part value to be joined.</param>
		/// <returns>return value is a 64-bit unsigned integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ulong WithHighUInt32(this ulong value, uint high) => (value.LowUInt32(), high).ToUInt64();

		/// <summary>
		/// Joins two 32-bit unsigned integer values and creates a 64-bit signed integer value.
		/// </summary>
		/// <param name="value">The lower part value to be joined.</param>
		/// <param name="high">The higher part value to be joined.</param>
		/// <returns>return value is a 64-bit signed integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static long WithHighUInt32(this long value, uint high) => (long)WithHighUInt32((ulong)value, high);

		/// <summary>
		/// Creates a 16-bit unsigned integer value by concatenating the specified values.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is a 16-bit unsigned integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ushort ToUInt16(this (byte low, byte high) value) => (ushort)(value.low | (value.high << 8));

		/// <summary>
		/// Creates a 16-bit signed integer value by concatenating the specified values.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is a 16-bit signed integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static short ToInt16(this (byte low, byte high) value) => (short)ToUInt16(value);

		/// <summary>
		/// Creates a 32-bit unsigned integer value by concatenating the specified values.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is a 32-bit unsigned integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static uint ToUInt32(this (ushort low, ushort high) value) => (uint)(value.low | (value.high << 16));
		
		/// <summary>
		/// Creates a 32-bit signed integer value by concatenating the specified values.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is a 32-bit signed integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static int ToInt32(this (ushort low, ushort high) value) => (int)ToUInt32(value);

		/// <summary>
		/// Creates a 64-bit unsigned integer value by concatenating the specified values.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is a 64-bit unsigned integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static ulong ToUInt64(this (uint low, uint high) value) => value.low | ((ulong)value.high << 32);

		/// <summary>
		/// Creates a 64-bit signed integer value by concatenating the specified values.
		/// </summary>
		/// <param name="value">The value to be converted.</param>
		/// <returns>The return value is a 64-bit signed integer value.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static long ToInt64(this (uint low, uint high) value) => (long)ToUInt64(value);
	}
}
