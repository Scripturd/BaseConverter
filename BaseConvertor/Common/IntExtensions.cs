namespace BaseConverter.Common;

public static class IntExtensions
{
    public static NumberSystem ToNumberSystem(this int decimalValue, Radix radix)
    {
        //Console.WriteLine($"decimalValue: {decimalValue} to radix: {radix}");

        int largestPower = 0;
        while (float.Pow(radix.Value, largestPower + 1) <= decimalValue)
            largestPower++;

        //Console.WriteLine($"largestPower: {largestPower}");

        List<Digit> digits = [];
        for (int power = largestPower; power >= 0; power--)
        {
            Digit digit = new((int)float.Floor(decimalValue / float.Pow(radix.Value, power)));

            //Console.WriteLine($"{decimalValue} - {digit} * {radix}^{power} = {decimalValue - digit.Value * (int)float.Pow(radix.Value, power)}");

            decimalValue -= digit.Value * (int)float.Pow(radix.Value, power);
            digits.Add(digit);
        }

        return new(radix, digits);
    }
}