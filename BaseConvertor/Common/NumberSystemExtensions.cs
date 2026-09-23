namespace BaseConverter.Common;

public static class NumberSystemExtensions
{
    public static NumberSystem WithRadix(this NumberSystem source, Radix targetRadix)
    {
        throw new NotImplementedException();
    }
    public static int GetDecimalValue(this NumberSystem source)
    {
        int decimalValue = 0;
        for (int i = 0; i < source.Digits.Count; i++)
        {
            decimalValue = decimalValue * source.Radix.Value + source.Digits[i].Value;
        }
        return decimalValue;
    }
}