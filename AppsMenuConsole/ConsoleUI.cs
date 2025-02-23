namespace AppsMenuConsole;

public class ConsoleUI
{
    public static void ShowMenu()
    {
        DisplayAppLogo();
    }

    public static void PrintText(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void DisplayApps()
    {
        string[] apps = new string[BatFilesManager.SearchBatFiles().Length];
        apps = BatFilesManager.SearchBatFiles().ToArray();

        for (int app = 0; app < apps.Length; app++)
        {
            apps[app] = apps[app].Replace(@"C:\Hobby\Alias\", "");
            apps[app] = apps[app].Replace(".bat", "");
            apps[app] = apps[app].ToUpper();
            PrintText($"{app + 1}. [{apps[app]}]");
        }
    }

    public static void ChooseApp()
    {
        PrintText("Choose an app: ");
        int.TryParse(Console.ReadLine(), out int choice);
        BatFilesManager.RunBatFile(choice);
    }

    public static void PrintText(string text)
    {
        Console.WriteLine(text);
    }
    
    public static void DisplayAppLogo()
    {
        /*
               ___                   __  ___             
              / _ | ___  ___  ___   /  |/  /__ ___  __ __
             / __ |/ _ \/ _ \(_-<  / /|_/ / -_) _ \/ // /
            /_/ |_/ .__/ .__/___/ /_/  /_/\__/_//_/\_,_/ 
                 /_/  /_/                                
         */
        Console.Clear();
        PrintText("-----------------------------------------------");
        PrintText("");
        PrintText("   ___                   __  ___             ", ConsoleColor.DarkYellow);
        PrintText("  / _ | ___  ___  ___   /  |/  /__ ___  __ __", ConsoleColor.DarkYellow);
        PrintText(" / __ |/ _ \\/ _ \\(_-<  / /|_/ / -_) _ \\/ // /", ConsoleColor.DarkMagenta);
        PrintText("/_/ |_/ .__/ .__/___/ /_/  /_/\\__/_//_/\\_,_/ ", ConsoleColor.DarkBlue);
        PrintText("     /_/  /_/                   ", ConsoleColor.DarkBlue);
        PrintText("");
        PrintText("-----------------------------------------------");
        PrintText("");
    }
}