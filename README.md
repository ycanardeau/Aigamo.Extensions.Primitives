<a name='assembly'></a>
# Aigamo.Extensions.Primitives

## Contents

- [BitExtensions](#T-Aigamo-Extensions-Primitives-BitExtensions 'Aigamo.Extensions.Primitives.BitExtensions')
  - [HighByte(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-HighByte-System-UInt16- 'Aigamo.Extensions.Primitives.BitExtensions.HighByte(System.UInt16)')
  - [HighByte(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-HighByte-System-Int16- 'Aigamo.Extensions.Primitives.BitExtensions.HighByte(System.Int16)')
  - [HighUInt16(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-HighUInt16-System-UInt32- 'Aigamo.Extensions.Primitives.BitExtensions.HighUInt16(System.UInt32)')
  - [HighUInt16(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-HighUInt16-System-Int32- 'Aigamo.Extensions.Primitives.BitExtensions.HighUInt16(System.Int32)')
  - [HighUInt32(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-HighUInt32-System-UInt64- 'Aigamo.Extensions.Primitives.BitExtensions.HighUInt32(System.UInt64)')
  - [HighUInt32(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-HighUInt32-System-Int64- 'Aigamo.Extensions.Primitives.BitExtensions.HighUInt32(System.Int64)')
  - [LowByte(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-LowByte-System-UInt16- 'Aigamo.Extensions.Primitives.BitExtensions.LowByte(System.UInt16)')
  - [LowByte(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-LowByte-System-Int16- 'Aigamo.Extensions.Primitives.BitExtensions.LowByte(System.Int16)')
  - [LowUInt16(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-LowUInt16-System-UInt32- 'Aigamo.Extensions.Primitives.BitExtensions.LowUInt16(System.UInt32)')
  - [LowUInt16(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-LowUInt16-System-Int32- 'Aigamo.Extensions.Primitives.BitExtensions.LowUInt16(System.Int32)')
  - [LowUInt32(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-LowUInt32-System-UInt64- 'Aigamo.Extensions.Primitives.BitExtensions.LowUInt32(System.UInt64)')
  - [LowUInt32(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-LowUInt32-System-Int64- 'Aigamo.Extensions.Primitives.BitExtensions.LowUInt32(System.Int64)')
  - [ToInt16(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-ToInt16-System-ValueTuple{System-Byte,System-Byte}- 'Aigamo.Extensions.Primitives.BitExtensions.ToInt16(System.ValueTuple{System.Byte,System.Byte})')
  - [ToInt32(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-ToInt32-System-ValueTuple{System-UInt16,System-UInt16}- 'Aigamo.Extensions.Primitives.BitExtensions.ToInt32(System.ValueTuple{System.UInt16,System.UInt16})')
  - [ToInt64(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-ToInt64-System-ValueTuple{System-UInt32,System-UInt32}- 'Aigamo.Extensions.Primitives.BitExtensions.ToInt64(System.ValueTuple{System.UInt32,System.UInt32})')
  - [ToUInt16(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-ToUInt16-System-ValueTuple{System-Byte,System-Byte}- 'Aigamo.Extensions.Primitives.BitExtensions.ToUInt16(System.ValueTuple{System.Byte,System.Byte})')
  - [ToUInt32(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-ToUInt32-System-ValueTuple{System-UInt16,System-UInt16}- 'Aigamo.Extensions.Primitives.BitExtensions.ToUInt32(System.ValueTuple{System.UInt16,System.UInt16})')
  - [ToUInt64(value)](#M-Aigamo-Extensions-Primitives-BitExtensions-ToUInt64-System-ValueTuple{System-UInt32,System-UInt32}- 'Aigamo.Extensions.Primitives.BitExtensions.ToUInt64(System.ValueTuple{System.UInt32,System.UInt32})')
  - [WithHighByte(value,high)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithHighByte-System-UInt16,System-Byte- 'Aigamo.Extensions.Primitives.BitExtensions.WithHighByte(System.UInt16,System.Byte)')
  - [WithHighByte(value,high)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithHighByte-System-Int16,System-Byte- 'Aigamo.Extensions.Primitives.BitExtensions.WithHighByte(System.Int16,System.Byte)')
  - [WithHighUInt16(value,high)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithHighUInt16-System-UInt32,System-UInt16- 'Aigamo.Extensions.Primitives.BitExtensions.WithHighUInt16(System.UInt32,System.UInt16)')
  - [WithHighUInt16(value,high)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithHighUInt16-System-Int32,System-UInt16- 'Aigamo.Extensions.Primitives.BitExtensions.WithHighUInt16(System.Int32,System.UInt16)')
  - [WithHighUInt32(value,high)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithHighUInt32-System-UInt64,System-UInt32- 'Aigamo.Extensions.Primitives.BitExtensions.WithHighUInt32(System.UInt64,System.UInt32)')
  - [WithHighUInt32(value,high)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithHighUInt32-System-Int64,System-UInt32- 'Aigamo.Extensions.Primitives.BitExtensions.WithHighUInt32(System.Int64,System.UInt32)')
  - [WithLowByte(value,low)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithLowByte-System-UInt16,System-Byte- 'Aigamo.Extensions.Primitives.BitExtensions.WithLowByte(System.UInt16,System.Byte)')
  - [WithLowByte(value,low)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithLowByte-System-Int16,System-Byte- 'Aigamo.Extensions.Primitives.BitExtensions.WithLowByte(System.Int16,System.Byte)')
  - [WithLowUInt16(value,low)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithLowUInt16-System-UInt32,System-UInt16- 'Aigamo.Extensions.Primitives.BitExtensions.WithLowUInt16(System.UInt32,System.UInt16)')
  - [WithLowUInt16(value,low)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithLowUInt16-System-Int32,System-UInt16- 'Aigamo.Extensions.Primitives.BitExtensions.WithLowUInt16(System.Int32,System.UInt16)')
  - [WithLowUInt32(value,low)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithLowUInt32-System-UInt64,System-UInt32- 'Aigamo.Extensions.Primitives.BitExtensions.WithLowUInt32(System.UInt64,System.UInt32)')
  - [WithLowUInt32(value,low)](#M-Aigamo-Extensions-Primitives-BitExtensions-WithLowUInt32-System-Int64,System-UInt32- 'Aigamo.Extensions.Primitives.BitExtensions.WithLowUInt32(System.Int64,System.UInt32)')

<a name='T-Aigamo-Extensions-Primitives-BitExtensions'></a>
## BitExtensions `type`

##### Namespace

Aigamo.Extensions.Primitives

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-HighByte-System-UInt16-'></a>
### HighByte(value) `method`

##### Summary

Retrieves the high-order byte from the given 16-bit value.

##### Returns

The return value is the high-order byte of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-HighByte-System-Int16-'></a>
### HighByte(value) `method`

##### Summary

Retrieves the high-order byte from the given 16-bit value.

##### Returns

The return value is the high-order byte of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-HighUInt16-System-UInt32-'></a>
### HighUInt16(value) `method`

##### Summary

Retrieves the high-order 16-bit unsigned integer from the given 32-bit value.

##### Returns

The return value is the high-order 16-bit unsigned integer of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-HighUInt16-System-Int32-'></a>
### HighUInt16(value) `method`

##### Summary

Retrieves the high-order 16-bit unsigned integer from the given 32-bit value.

##### Returns

The return value is the high-order 16-bit unsigned integer of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-HighUInt32-System-UInt64-'></a>
### HighUInt32(value) `method`

##### Summary

Retrieves the high-order 32-bit unsigned integer from the given 64-bit value.

##### Returns

The return value is the high-order 32-bit unsigned integer of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-HighUInt32-System-Int64-'></a>
### HighUInt32(value) `method`

##### Summary

Retrieves the high-order 32-bit unsigned integer from the given 64-bit value.

##### Returns

The return value is the high-order 32-bit unsigned integer of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-LowByte-System-UInt16-'></a>
### LowByte(value) `method`

##### Summary

Retrieves the low-order byte from the given 16-bit value.

##### Returns

The return value is the low-order byte of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-LowByte-System-Int16-'></a>
### LowByte(value) `method`

##### Summary

Retrieves the low-order byte from the given 16-bit value.

##### Returns

The return value is the low-order byte of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-LowUInt16-System-UInt32-'></a>
### LowUInt16(value) `method`

##### Summary

Retrieves the low-order 16-bit unsigned integer from the given 32-bit value.

##### Returns

The return value is the low-order 16-bit unsigned integer of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-LowUInt16-System-Int32-'></a>
### LowUInt16(value) `method`

##### Summary

Retrieves the low-order 16-bit unsigned integer from the given 32-bit value.

##### Returns

The return value is the low-order 16-bit unsigned integer of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-LowUInt32-System-UInt64-'></a>
### LowUInt32(value) `method`

##### Summary

Retrieves the low-order 32-bit unsigned integer from the given 64-bit value.

##### Returns

The return value is the low-order 32-bit unsigned integer of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-LowUInt32-System-Int64-'></a>
### LowUInt32(value) `method`

##### Summary

Retrieves the low-order 32-bit unsigned integer from the given 64-bit value.

##### Returns

The return value is the low-order 32-bit unsigned integer of the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-ToInt16-System-ValueTuple{System-Byte,System-Byte}-'></a>
### ToInt16(value) `method`

##### Summary

Creates a 16-bit signed integer value by concatenating the specified values.

##### Returns

The return value is a 16-bit signed integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueTuple{System.Byte,System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.Byte,System.Byte}') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-ToInt32-System-ValueTuple{System-UInt16,System-UInt16}-'></a>
### ToInt32(value) `method`

##### Summary

Creates a 32-bit signed integer value by concatenating the specified values.

##### Returns

The return value is a 32-bit signed integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueTuple{System.UInt16,System.UInt16}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.UInt16,System.UInt16}') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-ToInt64-System-ValueTuple{System-UInt32,System-UInt32}-'></a>
### ToInt64(value) `method`

##### Summary

Creates a 64-bit signed integer value by concatenating the specified values.

##### Returns

The return value is a 64-bit signed integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueTuple{System.UInt32,System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.UInt32,System.UInt32}') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-ToUInt16-System-ValueTuple{System-Byte,System-Byte}-'></a>
### ToUInt16(value) `method`

##### Summary

Creates a 16-bit unsigned integer value by concatenating the specified values.

##### Returns

The return value is a 16-bit unsigned integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueTuple{System.Byte,System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.Byte,System.Byte}') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-ToUInt32-System-ValueTuple{System-UInt16,System-UInt16}-'></a>
### ToUInt32(value) `method`

##### Summary

Creates a 32-bit unsigned integer value by concatenating the specified values.

##### Returns

The return value is a 32-bit unsigned integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueTuple{System.UInt16,System.UInt16}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.UInt16,System.UInt16}') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-ToUInt64-System-ValueTuple{System-UInt32,System-UInt32}-'></a>
### ToUInt64(value) `method`

##### Summary

Creates a 64-bit unsigned integer value by concatenating the specified values.

##### Returns

The return value is a 64-bit unsigned integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueTuple{System.UInt32,System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueTuple 'System.ValueTuple{System.UInt32,System.UInt32}') | The value to be converted. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithHighByte-System-UInt16,System-Byte-'></a>
### WithHighByte(value,high) `method`

##### Summary

Joins two byte values and creates a 16-bit unsigned integer value.

##### Returns

return value is a 16-bit unsigned integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The lower part value to be joined. |
| high | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The higher part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithHighByte-System-Int16,System-Byte-'></a>
### WithHighByte(value,high) `method`

##### Summary

Joins two byte values and creates a 16-bit signed integer value.

##### Returns

return value is a 16-bit signed integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The lower part value to be joined. |
| high | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The higher part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithHighUInt16-System-UInt32,System-UInt16-'></a>
### WithHighUInt16(value,high) `method`

##### Summary

Joins two 16-bit unsigned integer values and creates a 32-bit unsigned integer value.

##### Returns

return value is a 32-bit unsigned integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The lower part value to be joined. |
| high | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The higher part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithHighUInt16-System-Int32,System-UInt16-'></a>
### WithHighUInt16(value,high) `method`

##### Summary

Joins two 16-bit unsigned integer values and creates a 32-bit signed integer value.

##### Returns

return value is a 32-bit signed integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The lower part value to be joined. |
| high | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The higher part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithHighUInt32-System-UInt64,System-UInt32-'></a>
### WithHighUInt32(value,high) `method`

##### Summary

Joins two 32-bit unsigned integer values and creates a 64-bit unsigned integer value.

##### Returns

return value is a 64-bit unsigned integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The lower part value to be joined. |
| high | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The higher part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithHighUInt32-System-Int64,System-UInt32-'></a>
### WithHighUInt32(value,high) `method`

##### Summary

Joins two 32-bit unsigned integer values and creates a 64-bit signed integer value.

##### Returns

return value is a 64-bit signed integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The lower part value to be joined. |
| high | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The higher part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithLowByte-System-UInt16,System-Byte-'></a>
### WithLowByte(value,low) `method`

##### Summary

Joins two byte values and creates a 16-bit unsigned integer value.

##### Returns

return value is a 16-bit unsigned integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The higher part value to be joined. |
| low | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The lower part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithLowByte-System-Int16,System-Byte-'></a>
### WithLowByte(value,low) `method`

##### Summary

Joins two byte values and creates a 16-bit signed integer value.

##### Returns

return value is a 16-bit signed integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int16 'System.Int16') | The higher part value to be joined. |
| low | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The lower part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithLowUInt16-System-UInt32,System-UInt16-'></a>
### WithLowUInt16(value,low) `method`

##### Summary

Joins two 16-bit unsigned integer values and creates a 32-bit unsigned integer value.

##### Returns

return value is a 32-bit unsigned integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The higher part value to be joined. |
| low | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The lower part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithLowUInt16-System-Int32,System-UInt16-'></a>
### WithLowUInt16(value,low) `method`

##### Summary

Joins two 16-bit unsigned integer values and creates a 32-bit signed integer value.

##### Returns

return value is a 32-bit signed integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The higher part value to be joined. |
| low | [System.UInt16](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt16 'System.UInt16') | The lower part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithLowUInt32-System-UInt64,System-UInt32-'></a>
### WithLowUInt32(value,low) `method`

##### Summary

Joins two 32-bit unsigned integer values and creates a 64-bit unsigned integer value.

##### Returns

return value is a 64-bit unsigned integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The higher part value to be joined. |
| low | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The lower part value to be joined. |

<a name='M-Aigamo-Extensions-Primitives-BitExtensions-WithLowUInt32-System-Int64,System-UInt32-'></a>
### WithLowUInt32(value,low) `method`

##### Summary

Joins two 32-bit unsigned integer values and creates a 64-bit signed integer value.

##### Returns

return value is a 64-bit signed integer value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The higher part value to be joined. |
| low | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The lower part value to be joined. |
