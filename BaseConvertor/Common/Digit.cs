namespace BaseConverter.Common;

public readonly struct Digit
{
    public int Value { get; }

    public Digit(int value)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(value, 0);

        Value = value;
    }

    public override string ToString()
        => DigitSymbolMap.ToSymbol(this).ToString();
}