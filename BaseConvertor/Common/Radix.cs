namespace BaseConverter.Common;

public readonly struct Radix
{
    public int Value { get; }

    public Radix(int value)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(value, 2);

        Value = value;
    }

    public override string ToString()
        => NumberTextMap.ToSmallText(Value);
}