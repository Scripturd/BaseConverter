using BaseConverter.Common;

namespace BaseConverter.ConvertFromDecimal;

public class Game
{
    private readonly UiService _uiService;

    public Game(UiService uiService)
    {
        _uiService = uiService;
    }

    public void Start()
    {
        int selectedDecimalValue = _uiService.SelectInt("Select a number", min: 0);
        Radix radix = _uiService.SelectRadix("Select a radix.");
        NumberSystem numberSystem = selectedDecimalValue.ToNumberSystem(radix);

        _uiService.Print($"{selectedDecimalValue} = {numberSystem}");
    }
}