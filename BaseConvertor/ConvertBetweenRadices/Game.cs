using BaseConverter.Common;

namespace BaseConverter.ConvertBetweenRadices;

public class Game
{
    private readonly UiService _uiService;

    public Game(UiService uiService)
    {
        _uiService = uiService;
    }

    public void Start()
    {
        NumberSystem inputNumberSystem = _uiService.SelectNumberSystem();
        int decimalValue = inputNumberSystem.GetDecimalValue();
        //_uiService.Print($"{inputNumberSystem} = {decimalValue}");

        Radix outputRadix = _uiService.SelectRadix("Select a radix to convert to.");
        NumberSystem outputNumberSystem = decimalValue.ToNumberSystem(outputRadix);

        _uiService.Print($"{inputNumberSystem} = {outputNumberSystem}");
    }
}