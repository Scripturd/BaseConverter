namespace BaseConverter.Common;

public static class DigitSymbolMap
{
    private static readonly Dictionary<char, int> SymbolValues = new()
    {
        ['0'] = 0,
        ['1'] = 1,
        ['2'] = 2,
        ['3'] = 3,
        ['4'] = 4,
        ['5'] = 5,
        ['6'] = 6,
        ['7'] = 7,
        ['8'] = 8,
        ['9'] = 9,
        ['A'] = 10,
        ['B'] = 11,
        ['C'] = 12,
        ['D'] = 13,
        ['E'] = 14,
        ['F'] = 15,
        ['G'] = 16,
        ['H'] = 17,
        ['I'] = 18,
        ['J'] = 19,
        ['K'] = 20,
        ['L'] = 21,
        ['M'] = 22,
        ['N'] = 23,
        ['O'] = 24,
        ['P'] = 25,
        ['Q'] = 26,
        ['R'] = 27,
        ['S'] = 28,
        ['T'] = 29,
        ['U'] = 30,
        ['V'] = 31,
        ['W'] = 32,
        ['X'] = 33,
        ['Y'] = 34,
        ['Z'] = 35,
    };
    private static readonly Dictionary<int, char> ValueSymbols =
        SymbolValues.ToDictionary(pair => pair.Value, pair => pair.Key);

    public static int SymbolCount => SymbolValues.Count;

    public static char ToSymbol(Digit digit)
    {
        if (ValueSymbols.TryGetValue(digit.Value, out char symbol))
            return symbol;

        return '?';
    }
    public static bool TryToDigit(char source, out Digit digit)
    {
        if (SymbolValues.TryGetValue(char.ToUpperInvariant(source), out int value))
        {
            digit = new(value);
            return true;
        }

        digit = default;
        return false;
    }
    public static Digit? ToDigit(char source)
    {
        if (SymbolValues.TryGetValue(source, out int value))
        {
            return new(value);
        }

        return null;
    }
}