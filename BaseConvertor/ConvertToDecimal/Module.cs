using BaseConverter.Common;

namespace BaseConverter.ConvertToDecimal;

public class Module
{
    public Module(MainMenu mainMenu, UiService uiService)
    {
        Game game = new(uiService);
        StartCommand startCommand = new(game);
        mainMenu.Add(startCommand);
    }
}