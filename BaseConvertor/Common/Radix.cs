using System;

namespace BaseConverter.Common;

public readonly struct Radix : IEquatable<Radix>
{
    public int Value { get; }

    public Radix(int value)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(value, 2);

        Value = value;
    }

    public bool Equals(Radix other) => other.Value == Value;

    public override bool Equals(object? obj) => obj is Radix radix && Equals(radix);

    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(Radix lhs, Radix rhs)
        => lhs.Equals(rhs);
    public static bool operator !=(Radix lhs, Radix rhs)
    => !lhs.Equals(rhs);

    public override string ToString()
        => NumberTextMap.ToSmallText(Value);
}