using System;
using System.Diagnostics;

namespace AppsMenuConsole;

public class BatFilesManager
{
    private static string[] _batFiles;
    private static string _aliasDirectory = @"C:\Hobby\Alias";

    public static string[] SearchBatFiles()
    {
        _batFiles = Directory.GetFiles(_aliasDirectory, "*.bat");
        return _batFiles;
    }

    public static void RunBatFile(int fileNumber)
    {
        if (fileNumber <= _batFiles.Length && fileNumber > 0)
        {
            ConsoleUI.PrintText($"Choose File: {_batFiles[fileNumber - 1]}");
            Process process = new Process();
            process.StartInfo.FileName = _batFiles[fileNumber - 1];
            process.StartInfo.CreateNoWindow = true;
            process.Start();
        }
        else
        {
            Environment.Exit(0);
        }
    }
}