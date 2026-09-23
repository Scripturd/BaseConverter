namespace BaseConverter.Common;

public class NumberSystem
{
    public Radix Radix { get; }
    public IReadOnlyList<Digit> Digits { get; }

    public NumberSystem(Radix radix, IReadOnlyList<Digit> digits)
    {
        Radix = radix;
        Digits = digits;
    }

    public void Increase(out int remainder)
    {
        remainder = 0;
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