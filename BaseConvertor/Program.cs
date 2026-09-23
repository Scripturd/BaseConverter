using BaseConverter;
using BaseConverter.Common;

Random random = new();
UiService uiService = new(random);
MainMenu mainMenu = new(uiService);

new BaseConverter.ConvertBetweenRadices.Module(mainMenu, uiService);
new BaseConverter.ConvertFromDecimal.Module(mainMenu, uiService);
new BaseConverter.ConvertToDecimal.Module(mainMenu, uiService);

uiService.Clear();

uiService.Print("This app works best in PowerShell.");

if (uiService.Confirm("Would you like a quick guide on how to run it in PowerShell?"))
{
    uiService.Print("(1) Open PowerShell.");
    uiService.Print("(2) Navigate to this folder using \"cd < folder path > \".");
    uiService.Print("(3) Run the program using \"dotnet run\".");
}
else
{
    mainMenu.Open();
}