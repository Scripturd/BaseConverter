using BaseConverter.Common;

namespace BaseConverter.ConvertToDecimal;

public class StartCommand : ICommand
{
    private readonly Game _game;

    public string Name => "Convert to decimal";

    public StartCommand(Game game)
    {
        _game = game;
    }

    public void Execute()
    {
        _game.Start();
    }
}