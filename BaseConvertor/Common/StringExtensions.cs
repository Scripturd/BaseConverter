namespace BaseConverter.Common;

public static class StringExtensions
{
    public static bool TryToDigits(this string text, out List<Digit> digits)
    {
        digits = [];
        foreach (char symbol in text)
        {
            if (!DigitSymbolMap.TryToDigit(symbol, out Digit digit))
                return false;

            digits.Add(digit);
        }

        return true;
    }
}