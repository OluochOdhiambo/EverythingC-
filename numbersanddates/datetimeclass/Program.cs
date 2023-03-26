using System.Globalization;

// See https://aka.ms/new-console-template for more information
DateTime now = DateTime.Now;
Console.WriteLine(now);

// Today
DateTime today = DateTime.Today;
// Console.WriteLine(today.DayOfWeek);
// Console.WriteLine(today.DayOfYear);

// DateOnly and TimeOnly
DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);

// Manipulate date
now = now.AddDays(5);
now = now.AddMonths(6);
// Console.WriteLine(now);

// Format Dates
Console.WriteLine($"{now:G}");
Console.WriteLine($"{now:d}");

// Format to specific culture
Console.WriteLine(now.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

// Custom format
Console.WriteLine($"{now:dddd,MMMM, d yyyy}");
Console.WriteLine($"{now:MMM, d yyyy}");
