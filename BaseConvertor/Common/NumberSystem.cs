namespace BaseConverter.Common;

public class NumberSystem
{
    private readonly List<Digit> _digits;

    public Radix Radix { get; }
    /// <summary>
    /// The digits from most to least significant, in the order they are written: index 0 is the leftmost digit.
    /// The last digit is the ones place, so "1A" in radix 16 is stored as [1, A].
    /// </summary>
    public IReadOnlyList<Digit> Digits => _digits;

    public Digit this[int index]
    {
        get => index < Digits.Count ? Digits [index] : new Digit(0);
    }

    public NumberSystem(Radix radix, List<Digit> digits)
    {
        Radix = radix;
        _digits = digits;
    }

    public override string ToString()
        => $"{string.Concat(Digits)}{Radix}";
}