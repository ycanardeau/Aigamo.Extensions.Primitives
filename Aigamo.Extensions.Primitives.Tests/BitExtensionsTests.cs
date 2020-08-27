using Xunit;

namespace Aigamo.Extensions.Primitives.Tests
{
	public class BitExtensionsTests
	{
		[Theory]
		[InlineData(0x0000, 0x00)]
		[InlineData(0x1234, 0x34)]
		[InlineData(0x8765, 0x65)]
		[InlineData(0xFFFF, 0xFF)]
		public void LowByte(ushort value, byte expected)
		{
			Assert.Equal(expected, value.LowByte());
			Assert.Equal(expected, ((short)value).LowByte());
		}

		[Theory]
		[InlineData(0x00000000, 0x0000)]
		[InlineData(0x12345678, 0x5678)]
		[InlineData(0x87654321, 0x4321)]
		[InlineData(0xFFFFFFFF, 0xFFFF)]
		public void LowUInt16(uint value, ushort expected)
		{
			Assert.Equal(expected, value.LowUInt16());
			Assert.Equal(expected, ((int)value).LowUInt16());
		}

		[Theory]
		[InlineData(0x_00000000_00000000, 0x00000000)]
		[InlineData(0x_12345678_9ABCDEF0, 0x9ABCDEF0)]
		[InlineData(0x_0FEDCBA9_87654321, 0x87654321)]
		[InlineData(0x_FFFFFFFF_FFFFFFFF, 0xFFFFFFFF)]
		[InlineData(1979205471486323557L/*0x_1B778CE3_D973AB65*/, 0xD973AB65)]
		public void LowUInt32(ulong value, uint expected)
		{
			Assert.Equal(expected, value.LowUInt32());
			Assert.Equal(expected, ((long)value).LowUInt32());
		}

		[Theory]
		[InlineData(0x0000, 0x00)]
		[InlineData(0x1234, 0x12)]
		[InlineData(0x8765, 0x87)]
		[InlineData(0xFFFF, 0xFF)]
		public void HighByte(ushort value, byte expected)
		{
			Assert.Equal(expected, value.HighByte());
			Assert.Equal(expected, ((short)value).HighByte());
		}

		[Theory]
		[InlineData(0x00000000, 0x0000)]
		[InlineData(0x12345678, 0x1234)]
		[InlineData(0x87654321, 0x8765)]
		[InlineData(0xFFFFFFFF, 0xFFFF)]
		public void HighUInt16(uint value, ushort expected)
		{
			Assert.Equal(expected, value.HighUInt16());
			Assert.Equal(expected, ((int)value).HighUInt16());
		}

		[Theory]
		[InlineData(0x_00000000_00000000, 0x00000000)]
		[InlineData(0x_12345678_9ABCDEF0, 0x12345678)]
		[InlineData(0x_0FEDCBA9_87654321, 0x0FEDCBA9)]
		[InlineData(0x_FFFFFFFF_FFFFFFFF, 0xFFFFFFFF)]
		[InlineData(1979205471486323557L/*0x_1B778CE3_D973AB65*/, 0x1B778CE3)]
		public void HighUInt32(ulong value, uint expected)
		{
			Assert.Equal(expected, value.HighUInt32());
			Assert.Equal(expected, ((long)value).HighUInt32());
		}

		[Theory]
		[InlineData(0x0000, 0x12, 0x0012)]
		[InlineData(0x0000, 0x87, 0x0087)]
		[InlineData(0x1200, 0x34, 0x1234)]
		[InlineData(0x8700, 0x65, 0x8765)]
		public void WithLowByte(ushort value, byte low, ushort expected)
		{
			Assert.Equal(expected, value.WithLowByte(low));
			Assert.Equal((short)expected, ((short)value).WithLowByte(low));
		}

		[Theory]
		[InlineData(0x00000000, 0x1234, 0x00001234)]
		[InlineData(0x00000000, 0x8765, 0x00008765)]
		[InlineData(0x12340000, 0x5678, 0x12345678)]
		[InlineData(0x87650000, 0x4321, 0x87654321)]
		public void WithLowUInt16(uint value, ushort low, uint expected)
		{
			Assert.Equal(expected, value.WithLowUInt16(low));
			Assert.Equal((int)expected, ((int)value).WithLowUInt16(low));
		}

		[Theory]
		[InlineData(0x_00000000_00000000, 0x12345678, 0x_00000000_12345678)]
		[InlineData(0x_00000000_00000000, 0x0FEDCBA9, 0x_00000000_0FEDCBA9)]
		[InlineData(0x_12345678_00000000, 0x9ABCDEF0, 0x_12345678_9ABCDEF0)]
		[InlineData(0x_0FEDCBA9_00000000, 0x87654321, 0x_0FEDCBA9_87654321)]
		public void WithLowUInt32(ulong value, uint low, ulong expected)
		{
			Assert.Equal(expected, value.WithLowUInt32(low));
			Assert.Equal((long)expected, ((long)value).WithLowUInt32(low));
		}

		[Theory]
		[InlineData(0x0000, 0x12, 0x1200)]
		[InlineData(0x0000, 0x87, 0x8700)]
		[InlineData(0x0034, 0x12, 0x1234)]
		[InlineData(0x0065, 0x87, 0x8765)]
		public void WithHighByte(ushort value, byte high, ushort expected)
		{
			Assert.Equal(expected, value.WithHighByte(high));
			Assert.Equal((short)expected, ((short)value).WithHighByte(high));
		}

		[Theory]
		[InlineData(0x00000000, 0x1234, 0x12340000)]
		[InlineData(0x00000000, 0x8765, 0x87650000)]
		[InlineData(0x00005678, 0x1234, 0x12345678)]
		[InlineData(0x00004321, 0x8765, 0x87654321)]
		public void WithHighUInt16(uint value, ushort high, uint expected)
		{
			Assert.Equal(expected, value.WithHighUInt16(high));
			Assert.Equal((int)expected, ((int)value).WithHighUInt16(high));
		}

		[Theory]
		[InlineData(0x_00000000_00000000, 0x12345678, 0x_12345678_00000000)]
		[InlineData(0x_00000000_00000000, 0x0FEDCBA9, 0x_0FEDCBA9_00000000)]
		[InlineData(0x_00000000_9ABCDEF0, 0x12345678, 0x_12345678_9ABCDEF0)]
		[InlineData(0x_00000000_87654321, 0x0FEDCBA9, 0x_0FEDCBA9_87654321)]
		public void WithHighUInt32(ulong value, uint high, ulong expected)
		{
			Assert.Equal(expected, value.WithHighUInt32(high));
			Assert.Equal((long)expected, ((long)value).WithHighUInt32(high));
		}

		[Theory]
		[InlineData(byte.MinValue, byte.MinValue, 0x0000)]
		[InlineData(byte.MaxValue, byte.MinValue, 0x00FF)]
		[InlineData(byte.MinValue, byte.MaxValue, 0xFF00)]
		[InlineData(byte.MaxValue, byte.MaxValue, 0xFFFF)]
		[InlineData(0x34, 0x12, 0x1234)]
		public void ToUInt16(byte low, byte high, ushort expected)
		{
			Assert.Equal(expected, (low, high).ToUInt16());
			Assert.Equal(expected, (expected.LowByte(), expected.HighByte()).ToUInt16());

			Assert.Equal((short)expected, (low, high).ToInt16());
			Assert.Equal((short)expected, (((short)expected).LowByte(), ((short)expected).HighByte()).ToInt16());
		}

		[Theory]
		[InlineData(ushort.MinValue, ushort.MinValue, 0x00000000)]
		[InlineData(ushort.MaxValue, ushort.MinValue, 0x0000FFFF)]
		[InlineData(ushort.MinValue, ushort.MaxValue, 0xFFFF0000)]
		[InlineData(ushort.MaxValue, ushort.MaxValue, 0xFFFFFFFF)]
		[InlineData(0x5678, 0x1234, 0x12345678)]
		public void ToUInt32(ushort low, ushort high, uint expected)
		{
			Assert.Equal(expected, (low, high).ToUInt32());
			Assert.Equal(expected, (expected.LowUInt16(), expected.HighUInt16()).ToUInt32());

			Assert.Equal((int)expected, (low, high).ToInt32());
			Assert.Equal((int)expected, (((int)expected).LowUInt16(), ((int)expected).HighUInt16()).ToInt32());
		}

		[Theory]
		[InlineData(uint.MinValue, uint.MinValue, 0x_00000000_00000000)]
		[InlineData(uint.MaxValue, uint.MinValue, 0x_00000000_FFFFFFFF)]
		[InlineData(uint.MinValue, uint.MaxValue, 0x_FFFFFFFF_00000000)]
		[InlineData(uint.MaxValue, uint.MaxValue, 0x_FFFFFFFF_FFFFFFFF)]
		[InlineData(0x9ABCDEF0, 0x12345678, 0x123456789ABCDEF0)]
		[InlineData(0xD973AB65, 0x1B778CE3, 1979205471486323557L/*0x_1B778CE3_D973AB65*/)]
		public void ToUInt64(uint low, uint high, ulong expected)
		{
			Assert.Equal(expected, (low, high).ToUInt64());
			Assert.Equal(expected, (expected.LowUInt32(), expected.HighUInt32()).ToUInt64());

			Assert.Equal((long)expected, (low, high).ToInt64());
			Assert.Equal((long)expected, (((long)expected).LowUInt32(), ((long)expected).HighUInt32()).ToInt64());
		}
	}
}
