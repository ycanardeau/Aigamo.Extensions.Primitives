using System.Runtime.CompilerServices;

namespace Aigamo.Extensions.Primitives;

public static class BitExtensions
{
	/// <param name="value">The value to be converted.</param>
	extension(ushort value)
	{
		/// <summary>
		/// Gets the low-order byte from the given 16-bit value.
		/// </summary>
		/// <value>The low-order byte of the specified value.</value>
		public byte LowByte
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (byte)value;
		}

		/// <summary>
		/// Gets the high-order byte from the given 16-bit value.
		/// </summary>
		/// <value>The high-order byte of the specified value.</value>
		public byte HighByte
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (byte)(value >> 8);
		}
	}

	/// <param name="value">The value to be converted.</param>
	extension(short value)
	{
		/// <summary>
		/// Gets the low-order byte from the given 16-bit value.
		/// </summary>
		/// <value>The low-order byte of the specified value.</value>
		public byte LowByte
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ((ushort)value).LowByte;
		}

		/// <summary>
		/// Gets the high-order byte from the given 16-bit value.
		/// </summary>
		/// <value>The high-order byte of the specified value.</value>
		public byte HighByte
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ((ushort)value).HighByte;
		}
	}

	/// <param name="value">The value to be converted.</param>
	extension(uint value)
	{
		/// <summary>
		/// Gets the low-order 16-bit unsigned integer from the given 32-bit value.
		/// </summary>
		/// <value>The low-order 16-bit unsigned integer of the specified value.</value>
		public ushort LowUInt16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (ushort)value;
		}

		/// <summary>
		/// Gets the high-order 16-bit unsigned integer from the given 32-bit value.
		/// </summary>
		/// <value>The high-order 16-bit unsigned integer of the specified value.</value>
		public ushort HighUInt16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (ushort)(value >> 16);
		}
	}

	/// <param name="value">The value to be converted.</param>
	extension(int value)
	{
		/// <summary>
		/// Gets the low-order 16-bit unsigned integer from the given 32-bit value.
		/// </summary>
		/// <value>The low-order 16-bit unsigned integer of the specified value.</value>
		public ushort LowUInt16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ((uint)value).LowUInt16;
		}

		/// <summary>
		/// Gets the high-order 16-bit unsigned integer from the given 32-bit value.
		/// </summary>
		/// <value>The high-order 16-bit unsigned integer of the specified value.</value>
		public ushort HighUInt16
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ((uint)value).HighUInt16;
		}
	}

	/// <param name="value">The value to be converted.</param>
	extension(ulong value)
	{
		/// <summary>
		/// Gets the low-order 32-bit unsigned integer from the given 64-bit value.
		/// </summary>
		/// <value>The low-order 32-bit unsigned integer of the specified value.</value>
		public uint LowUInt32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (uint)value;
		}

		/// <summary>
		/// Gets the high-order 32-bit unsigned integer from the given 64-bit value.
		/// </summary>
		/// <value>The high-order 32-bit unsigned integer of the specified value.</value>
		public uint HighUInt32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => (uint)(value >> 32);
		}
	}

	/// <param name="value">The value to be converted.</param>
	extension(long value)
	{
		/// <summary>
		/// Gets the low-order 32-bit unsigned integer from the given 64-bit value.
		/// </summary>
		/// <value>The low-order 32-bit unsigned integer of the specified value.</value>
		public uint LowUInt32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ((ulong)value).LowUInt32;
		}

		/// <summary>
		/// Gets the high-order 32-bit unsigned integer from the given 64-bit value.
		/// </summary>
		/// <value>The high-order 32-bit unsigned integer of the specified value.</value>
		public uint HighUInt32
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ((ulong)value).HighUInt32;
		}
	}

	/// <summary>
	/// Creates a 16-bit unsigned integer value by concatenating the specified values.
	/// </summary>
	/// <param name="value">The value to be converted.</param>
	/// <returns>The return value is a 16-bit unsigned integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ushort ToUInt16(this (byte Low, byte High) value) =>
		(ushort)(value.Low | (value.High << 8));

	/// <summary>
	/// Creates a 16-bit signed integer value by concatenating the specified values.
	/// </summary>
	/// <param name="value">The value to be converted.</param>
	/// <returns>The return value is a 16-bit signed integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short ToInt16(this (byte Low, byte High) value) => (short)ToUInt16(value);

	/// <summary>
	/// Creates a 32-bit unsigned integer value by concatenating the specified values.
	/// </summary>
	/// <param name="value">The value to be converted.</param>
	/// <returns>The return value is a 32-bit unsigned integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint ToUInt32(this (ushort Low, ushort High) value) =>
		(uint)(value.Low | (value.High << 16));

	/// <summary>
	/// Creates a 32-bit signed integer value by concatenating the specified values.
	/// </summary>
	/// <param name="value">The value to be converted.</param>
	/// <returns>The return value is a 32-bit signed integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int ToInt32(this (ushort Low, ushort High) value) => (int)ToUInt32(value);

	/// <summary>
	/// Creates a 64-bit unsigned integer value by concatenating the specified values.
	/// </summary>
	/// <param name="value">The value to be converted.</param>
	/// <returns>The return value is a 64-bit unsigned integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong ToUInt64(this (uint Low, uint High) value) =>
		value.Low | ((ulong)value.High << 32);

	/// <summary>
	/// Creates a 64-bit signed integer value by concatenating the specified values.
	/// </summary>
	/// <param name="value">The value to be converted.</param>
	/// <returns>The return value is a 64-bit signed integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long ToInt64(this (uint Low, uint High) value) => (long)ToUInt64(value);

	/// <summary>
	/// Joins two byte values and creates a 16-bit unsigned integer value.
	/// </summary>
	/// <param name="value">The higher part value to be joined.</param>
	/// <param name="low">The lower part value to be joined.</param>
	/// <returns>return value is a 16-bit unsigned integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ushort WithLowByte(this ushort value, byte low) =>
		(low, value.HighByte).ToUInt16();

	/// <summary>
	/// Joins two byte values and creates a 16-bit signed integer value.
	/// </summary>
	/// <param name="value">The higher part value to be joined.</param>
	/// <param name="low">The lower part value to be joined.</param>
	/// <returns>return value is a 16-bit signed integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short WithLowByte(this short value, byte low) =>
		(short)WithLowByte((ushort)value, low);

	/// <summary>
	/// Joins two 16-bit unsigned integer values and creates a 32-bit unsigned integer value.
	/// </summary>
	/// <param name="value">The higher part value to be joined.</param>
	/// <param name="low">The lower part value to be joined.</param>
	/// <returns>return value is a 32-bit unsigned integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint WithLowUInt16(this uint value, ushort low) =>
		(low, value.HighUInt16).ToUInt32();

	/// <summary>
	/// Joins two 16-bit unsigned integer values and creates a 32-bit signed integer value.
	/// </summary>
	/// <param name="value">The higher part value to be joined.</param>
	/// <param name="low">The lower part value to be joined.</param>
	/// <returns>return value is a 32-bit signed integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int WithLowUInt16(this int value, ushort low) =>
		(int)WithLowUInt16((uint)value, low);

	/// <summary>
	/// Joins two 32-bit unsigned integer values and creates a 64-bit unsigned integer value.
	/// </summary>
	/// <param name="value">The higher part value to be joined.</param>
	/// <param name="low">The lower part value to be joined.</param>
	/// <returns>return value is a 64-bit unsigned integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong WithLowUInt32(this ulong value, uint low) =>
		(low, value.HighUInt32).ToUInt64();

	/// <summary>
	/// Joins two 32-bit unsigned integer values and creates a 64-bit signed integer value.
	/// </summary>
	/// <param name="value">The higher part value to be joined.</param>
	/// <param name="low">The lower part value to be joined.</param>
	/// <returns>return value is a 64-bit signed integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long WithLowUInt32(this long value, uint low) =>
		(long)WithLowUInt32((ulong)value, low);

	/// <summary>
	/// Joins two byte values and creates a 16-bit unsigned integer value.
	/// </summary>
	/// <param name="value">The lower part value to be joined.</param>
	/// <param name="high">The higher part value to be joined.</param>
	/// <returns>return value is a 16-bit unsigned integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ushort WithHighByte(this ushort value, byte high) =>
		(value.LowByte, high).ToUInt16();

	/// <summary>
	/// Joins two byte values and creates a 16-bit signed integer value.
	/// </summary>
	/// <param name="value">The lower part value to be joined.</param>
	/// <param name="high">The higher part value to be joined.</param>
	/// <returns>return value is a 16-bit signed integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short WithHighByte(this short value, byte high) =>
		(short)WithHighByte((ushort)value, high);

	/// <summary>
	/// Joins two 16-bit unsigned integer values and creates a 32-bit unsigned integer value.
	/// </summary>
	/// <param name="value">The lower part value to be joined.</param>
	/// <param name="high">The higher part value to be joined.</param>
	/// <returns>return value is a 32-bit unsigned integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint WithHighUInt16(this uint value, ushort high) =>
		(value.LowUInt16, high).ToUInt32();

	/// <summary>
	/// Joins two 16-bit unsigned integer values and creates a 32-bit signed integer value.
	/// </summary>
	/// <param name="value">The lower part value to be joined.</param>
	/// <param name="high">The higher part value to be joined.</param>
	/// <returns>return value is a 32-bit signed integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int WithHighUInt16(this int value, ushort high) =>
		(int)WithHighUInt16((uint)value, high);

	/// <summary>
	/// Joins two 32-bit unsigned integer values and creates a 64-bit unsigned integer value.
	/// </summary>
	/// <param name="value">The lower part value to be joined.</param>
	/// <param name="high">The higher part value to be joined.</param>
	/// <returns>return value is a 64-bit unsigned integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong WithHighUInt32(this ulong value, uint high) =>
		(value.LowUInt32, high).ToUInt64();

	/// <summary>
	/// Joins two 32-bit unsigned integer values and creates a 64-bit signed integer value.
	/// </summary>
	/// <param name="value">The lower part value to be joined.</param>
	/// <param name="high">The higher part value to be joined.</param>
	/// <returns>return value is a 64-bit signed integer value.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long WithHighUInt32(this long value, uint high) =>
		(long)WithHighUInt32((ulong)value, high);
}
