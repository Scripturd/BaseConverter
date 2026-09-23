using BaseConverter.Common;

namespace BaseConverter.ConvertFromDecimal;

public class StartCommand : ICommand
{
    private readonly Game _game;

    public string Name => "Convert from decimal";

    public StartCommand(Game game)
    {
        _game = game;
    }

    public void Execute()
    {
        _game.Start();
    }
}