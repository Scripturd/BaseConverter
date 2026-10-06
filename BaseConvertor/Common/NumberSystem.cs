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

    public void Increase()
    {

    }
    private NumberSystem Add(int digitIndex, Digit addendDigit)
    {
        List<Digit> addendDigits = [];
        for (int i = 0; i < digitIndex - 1; i++)
        {
            addendDigits.Add(new Digit(0));
        }
        addendDigits.Add(addendDigit);
        // If digitIndex is 4 & addend is 1
        // output: 1000

        NumberSystem addendSystem = new(Radix, addendDigits);
        return Add(addendSystem);
    }
    public NumberSystem Add(NumberSystem other)
    {
        if (other.Radix != Radix)
            throw new InvalidOperationException("The radices don't match!");

        List<Digit> sumDigits = [];
        List<Digit> carryDigits = [];
        for (int i = 0; i < other.Digits.Count - 1; i++)
        {
            sumDigits.Add(new Digit(0));
        }

        throw new NotImplementedException();
    }
    private void Add(NumberSystem a, NumberSystem b, out NumberSystem sum, out NumberSystem carry)
    {
        throw new NotImplementedException();
    }
    public void Add(Digit a, Digit b, out Digit sum, out Digit carry)
    {
        int sumInt = (a.Value + b.Value) % Radix.Value;
        int carryInt = (int)MathF.Floor((a.Value + b.Value) / Radix.Value);

        Console.Write($"{a} + {b} = {sumInt}, carry {carryInt}");

        throw new NotImplementedException();
    }

    public override string ToString()
        => $"{string.Concat(Digits)}{Radix}";
}