namespace BaseConverter.Common;

public class UiService
{
    private readonly Random _random;

    public UiService(Random random)
    {
        _random = random;
    }

    public void Clear()
    {
        Console.Clear();
    }
    public void Space(int thickness = 1)
    {
        if (thickness < 1 || thickness > 10)
            throw new ArgumentOutOfRangeException(nameof(thickness));

        for (int i = 0; i < thickness; i++)
            Print("");
    }
    public void HorizontalBar(int thickness = 1)
    {
        if (thickness < 1 || thickness > 10)
            throw new ArgumentOutOfRangeException(nameof(thickness));

        Space();

        for (int i = 0; i < thickness; i++)
            Print("--------------------------------------------------------------");

        Space();
    }
    public void Print(string text)
    {
        Console.WriteLine(text);
    }

    public string ReadLine()
    {
        if (!Console.IsOutputRedirected)
            Console.CursorVisible = true;
        string? input = Console.ReadLine();
        if (!Console.IsOutputRedirected)
            Console.CursorVisible = false;

        if (input == null)
            return string.Empty;

        return input;
    }

    public bool Confirm(string question)
    {
        Print(question + " (y/n)");
        string answer = ReadLine();

        bool answeredYes = answer.Equals("y", StringComparison.CurrentCultureIgnoreCase);
        bool answeredNo = answer.Equals("n", StringComparison.CurrentCultureIgnoreCase);

        if (!answeredYes && !answeredNo)
        {
            Print("Please answer with (y) or (n)");
            return Confirm(question);
        }

        return answeredYes;
    }

    public int SelectInt(string question, int min = int.MinValue, int max = int.MaxValue)
    {
        Print(question);
        return SelectInt(min, max);
    }
    private int SelectInt(int min = int.MinValue, int max = int.MaxValue)
    {
        string input = ReadLine();

        bool isValidInteger = int.TryParse(input, out int parsedInput);

        if (parsedInput < min)
        {
            isValidInteger = false;
            Print($"Your number can't be less than {min}");
        }
        else if (parsedInput > max)
        {
            isValidInteger = false;
            Print($"Your number can't be more than {max}");
        }
        else if (!isValidInteger)
            Print("Type a valid integer");

        if (isValidInteger)
            return parsedInput;
        else
            return SelectInt(min, max);
    }

    public NumberSystem SelectNumberSystem()
    {
        Radix selectedRadix = SelectRadix("Select a radix");

        Print($"Write a number in radix {selectedRadix}");
        return SelectNumberSystem(selectedRadix);
    }
    private NumberSystem SelectNumberSystem(Radix radix)
    {
        string text = ReadLine();
        if (!text.TryToDigits(out List<Digit> digits))
        {
            Print($"\"{text}{radix}\" is not valid.");
            return SelectNumberSystem(radix);
        }

        foreach (Digit digit in digits)
        {
            if (digit.Value >= radix.Value)
            {
                Print($"\"{text}{radix}\" is not valid.");
                return SelectNumberSystem(radix);
            }
        }

        return new NumberSystem(radix, digits);
    }
    public Radix SelectRadix(string question)
    {
        int value = SelectInt(question, 2, DigitSymbolMap.SymbolCount);
        return new Radix(value);
    }

    public void WaitForKeyPress()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }

    public int SelectString(string question, string[] choices)
    {
        Print(question);

        for (int i = 0; i < choices.Length; i++)
            Print($"({i}): {choices[i]}");

        int selectedIndex = SelectInt(min: 0, max: choices.Length - 1);

        Print($"You selected ({choices[selectedIndex]})");
        Space();

        return selectedIndex;
    }

    public T SelectEnum<T>(
    string question)
    where T : struct, Enum
    {
        string[] options = Enum.GetNames<T>();
        int index = SelectString(question, options);

        return Enum.GetValues<T>()[index];
    }
}