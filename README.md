# Aigamo.Extensions.Primitives

Small, allocation-free helpers for splitting integers into their low and high halves and joining them back together.

```csharp
using Aigamo.Extensions.Primitives;

ushort value = 0x1234;

byte low = value.LowByte;   // 0x34
byte high = value.HighByte; // 0x12

ushort replaced = value.WithLowByte(0xFF); // 0x12FF
ushort joined = (low, high).ToUInt16();    // 0x1234
```

## Installation

```sh
dotnet add package Aigamo.Extensions.Primitives
```

### Requirements

- The package targets **.NET Standard 2.0**, so it can be referenced from .NET Framework 4.6.1+, .NET Core 2.0+, .NET 5+, Mono, and Unity.
- `LowByte`, `HighByte`, and the other `Low*`/`High*` members are [C# 14 extension properties](https://learn.microsoft.com/dotnet/csharp/language-reference/proposals/csharp-14.0/extensions). To use them as properties, the consuming project needs **C# 14 or later** (the .NET 10 SDK or newer). On older language versions, they can only be called as static methods, for example `BitExtensions.get_LowByte(value)`.
- `With*` and `To*` are regular extension methods and work with any C# version.

## API

Signed types split into **unsigned** halves, so the sign bit shows up in the high half rather than being sign-extended.

### Splitting: `Low*` / `High*` (extension properties)

| Receiver | Properties | Result type |
| --- | --- | --- |
| `ushort`, `short` | `LowByte`, `HighByte` | `byte` |
| `uint`, `int` | `LowUInt16`, `HighUInt16` | `ushort` |
| `ulong`, `long` | `LowUInt32`, `HighUInt32` | `uint` |

```csharp
int value = -1;
ushort high = value.HighUInt16; // 0xFFFF
```

### Replacing one half: `With*` (extension methods)

Each method returns a copy of the value with one half replaced. The result has the same type as the receiver.

| Receiver | Methods | Argument type |
| --- | --- | --- |
| `ushort`, `short` | `WithLowByte`, `WithHighByte` | `byte` |
| `uint`, `int` | `WithLowUInt16`, `WithHighUInt16` | `ushort` |
| `ulong`, `long` | `WithLowUInt32`, `WithHighUInt32` | `uint` |

```csharp
uint value = 0x12345678;
uint a = value.WithLowUInt16(0xABCD);  // 0x1234ABCD
uint b = value.WithHighUInt16(0xABCD); // 0xABCD5678
```

### Joining: `To*` (extension methods on `(low, high)` tuples)

| Receiver | Methods |
| --- | --- |
| `(byte low, byte high)` | `ToUInt16`, `ToInt16` |
| `(ushort low, ushort high)` | `ToUInt32`, `ToInt32` |
| `(uint low, uint high)` | `ToUInt64`, `ToInt64` |

```csharp
uint low = 0x9ABCDEF0;
uint high = 0x12345678;
ulong joined = (low, high).ToUInt64(); // 0x123456789ABCDEF0
```

The tuple elements must already have the right types. `(0x34, 0x12).ToUInt16()` does not compile, because the literals are `int`.

## Development

Building requires the .NET 10 SDK or newer.

```sh
dotnet build
dotnet test
```

Code is formatted with [CSharpier](https://csharpier.com):

```sh
dotnet tool restore
dotnet csharpier format .
```

## License

[MIT](LICENSE)
