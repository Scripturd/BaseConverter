namespace BaseConverter.Common;

public interface ICommand
{
    string Name { get; }
    void Execute();
}