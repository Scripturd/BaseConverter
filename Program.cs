using System;

class Program
{
    static void Main()
    {
        int inputBase;
        int outputBase;
        string inputNum;
        int base10num = 0;

        Console.WriteLine("number");
        inputNum = Console.ReadLine();

        if (inputNum == null)
        {
            return;
        }

        Console.WriteLine("base");

        if (!int.TryParse(Console.ReadLine(), out inputBase))
        {
            return;
        }

        Console.WriteLine("desired base");

        if (!int.TryParse(Console.ReadLine(), out outputBase))
        {
            return;
        }

        // Check that bases are supported
        if (inputBase < 2 || inputBase > 20)
        {
            Console.WriteLine("Input base must be between 2 and 20");
            return;
        }

        if (outputBase < 2 || outputBase > 20)
        {
            Console.WriteLine("Output base must be between 2 and 20");
            return;
        }

        // Check that the number is valid for the given base
        if (!ValidNumber(inputNum, inputBase))
        {
            Console.WriteLine("Invalid number for base " + inputBase);
            return;
        }

        // Convert input number to base 10
        for (int i = 0; i < inputNum.Length; i++)
        {
            int digit = 0;

            if (inputNum[i] >= '0' && inputNum[i] <= '9')
            {
                digit = inputNum[i] - '0';
            }
            else if (inputNum[i] >= 'A' && inputNum[i] <= 'J')
            {
                digit = inputNum[i] - 'A' + 10;
            }

            int exponent = Pow(inputBase, inputNum.Length - 1 - i);

            base10num += digit * exponent;
        }

        Console.WriteLine("Base 10: " + base10num);
        Console.WriteLine("Converted: " + ToBase(base10num, outputBase));
    }

    static bool ValidNumber(string num, int baseValue)
    {
        for (int i = 0; i < num.Length; i++)
        {
            int digit;

            if (num[i] >= '0' && num[i] <= '9')
            {
                digit = num[i] - '0';
            }
            else if (num[i] >= 'A' && num[i] <= 'J')
            {
                digit = num[i] - 'A' + 10;
            }
            else
            {
                // Character isn't a supported digit
                return false;
            }

            // A digit must always be smaller than its base
            if (digit >= baseValue)
            {
                return false;
            }
        }

        return true;
    }

    static int Pow(int a, int b)
    {
        int result = 1;

        while (b > 0)
        {
            if ((b & 1) == 1)
            {
                result *= a;
            }

            a *= a;
            b >>= 1;
        }

        return result;
    }

    static string ToBase(int n, int baseValue)
    {
        const string digits = "0123456789ABCDEFGHIJ";

        if (n == 0)
        {
            return "0";
        }

        string result = "";

        while (n > 0)
        {
            int remainder = n % baseValue;
            result = digits[remainder] + result;
            n /= baseValue;
        }

        return result;
    }
}