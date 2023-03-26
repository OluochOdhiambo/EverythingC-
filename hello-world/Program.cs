// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? response;

Console.WriteLine("What's your name?");
response = Console.ReadLine();
Console.WriteLine($"Enjoy your course {response}");

OperatingSystem thisOs= Environment.OSVersion;
Console.WriteLine(thisOs.Platform);
Console.WriteLine(thisOs.VersionString);
