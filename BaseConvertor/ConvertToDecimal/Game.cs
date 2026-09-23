using BaseConverter.Common;

namespace BaseConverter.ConvertToDecimal;

public class Game
{
    private readonly UiService _uiService;

    public Game(UiService uiService)
    {
        _uiService = uiService;
    }

    public void Start()
    {
        NumberSystem selectedNumberSystem = _uiService.SelectNumberSystem();
        int decimalValue = selectedNumberSystem.GetDecimalValue();

        _uiService.Print($"{selectedNumberSystem} = {decimalValue}");
        selectedNumberSystem.Add(new(1), new(1), out var s, out var c);
    }

}