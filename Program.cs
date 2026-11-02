// ﻿Console.WriteLine($"компьютер: {Environment.MachineName}");

// Console.WriteLine($"пользователь: {Environment.UserName}");

// Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");


// Console.WriteLine($"OC: {Environment.OSVersion}");
// Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");

// Console.WriteLine($"логических процесов: {Environment.ProcessorCount}");

// Console.WriteLine($"PID процесса : {Environment.ProcessId}");
// long memory = Environment.WorkingSet / 1024 / 1024;
// Console.WriteLine($"Память процесса: {memory} МБ");
// Console.WriteLine();


using System.Diagnostics;

Console.WriteLine("Мини-монитор систем\n");

Console.WriteLine($"компьютер:{Environment.MachineName}");

Console.WriteLine($"пользователь:{Environment.UserName}");

Console.WriteLine($"OC:{Environment.OSVersion}");

Console.WriteLine($"64-bit:{Environment.Is64BitOperatingSystem}");

Console.WriteLine($"процесор:{Environment.ProcessorCount}");

Process currentProcces = Process.GetCurrentProcess();

Console.WriteLine($"PID процесса:{currentProcces.Id}\n");
Console.WriteLine("память процесса: ");


for (int i = 1; i <= 3; i++)
{
    currentProcces.Refresh();
    long memory = currentProcces.WorkingSet64 / 1024 / 1024;
    Console.WriteLine($"{i} измение:{memory} МБ");
    if(i < 3)
    {
        Console.WriteLine("обновите окно через несколько секунд...");
        Console.ReadLine();
    }
}

Console.WriteLine("иследование завершено.");