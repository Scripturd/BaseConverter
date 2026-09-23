namespace BaseConverter.Common;

public static class IntExtensions
{
    public static NumberSystem ToNumberSystem(this int decimalValue, Radix radix)
    {

        string result = string.Empty;
        for (int i = 0; decimalValue > 0; i++)
        {
            result = decimalValue % 2 + result;
            decimalValue = decimalValue / 2;
        }

        Console.WriteLine(result);
        throw new NotImplementedException();
    }
}