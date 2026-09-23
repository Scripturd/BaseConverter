using BaseConverter.Common;

namespace BaseConverter.ConvertBetweenRadices;

public class StartCommand : ICommand
{
    private readonly Game _game;

    public string Name => "Convert between radices";

    public StartCommand(Game game)
    {
        _game = game;
    }

    public void Execute()
    {
        _game.Start();
    }
}