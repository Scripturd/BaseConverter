using BaseConverter.Common;

namespace BaseConverter;

public class MainMenu
{
    private readonly UiService _uiService;
    private readonly List<ICommand> _commands = [];

    public MainMenu(UiService uiService)
    {
        _uiService = uiService;
    }

    public void Add(ICommand command)
    {
        _commands.Add(command);
    }

    public void Open()
    {
        _uiService.Clear();
        ICommand selectedCommand = SelectCommand(_commands, "Select a command:");
        _uiService.Clear();
        selectedCommand.Execute();
        _uiService.HorizontalBar();
        _uiService.WaitForKeyPress();
        Open();
    }

    public ICommand SelectCommand(
        IReadOnlyList<ICommand> commands,
        string question)
    {
        string[] commandNames = [.. commands.Select(command => command.Name)];

        int index = _uiService.SelectString(question, commandNames);

        return commands[index];
    }
}