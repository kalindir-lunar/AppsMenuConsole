namespace AppsMenuConsole;

class Program
{
    static void Main(string[] args)
    {
        RunApp();
    }

    static void RunApp()
    {
        ConsoleUI.ShowMenu();
        ConsoleUI.DisplayApps();
        ConsoleUI.ChooseApp();
        RunApp();
    }
}