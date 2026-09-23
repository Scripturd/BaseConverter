namespace BaseConvertor.Common;

public class UiService
{
    private readonly Random _random;

    public UiService(Random random)
    {
        _random = random;
    }

    public void ClearLastLine()
    {
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, Console.CursorTop);
    }
    public void ReplaceLastLine(string text)
    {
        int line = Console.CursorTop - 1;

        Console.SetCursorPosition(0, line);
        Console.Write(text.PadRight(Console.WindowWidth - 1));
        Console.SetCursorPosition(0, line + 1);
    }
    public void ReplaceLine(int top, string text)
    {
        int currentTop = Console.CursorTop;
        int currentLeft = Console.CursorLeft;

        Console.SetCursorPosition(0, top);

        int width = Console.WindowWidth;

        if (text.Length > width)
            text = text[..width];

        Console.Write(text.PadRight(width));

        Console.SetCursorPosition(currentLeft, currentTop);
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
        Console.CursorVisible = true;
        string? input = Console.ReadLine();
        Console.CursorVisible = false;

        if (input == null)
            return string.Empty;

        return input;
    }

    public bool Confirm(string question)
    {
        Print(question);
        string answer = ReadLine();

        return answer.Equals("y", StringComparison.CurrentCultureIgnoreCase);
    }

    public int SelectInt(string question, int min = int.MinValue, int max = int.MaxValue)
    {
        Print(question);



        return AnsiConsole.Prompt(
            new TextPrompt<int>(question)
                .Validate(x =>
                {
                    if (x < min || x > max)
                        return ValidationResult.Error($"Enter a number between {min} and {max}.");

                    return ValidationResult.Success();
                }));
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