// See https://aka.ms/new-console-template for more information
DateTime date;
bool isParsed;
bool exit = false;

while (exit == false)
{
    Console.WriteLine("Which date? / 'exit'");
    string readValue = Console.ReadLine();
    if (readValue == "exit") {
        exit = true;
        return;
    }

    isParsed = DateTime.TryParse(readValue, out date);
    if (isParsed != true) {
        Console.WriteLine("Incorrect date format.");
        return;
    }

    DateTime today = DateTime.Today;
    if (date > today) {
        double diff = (date - today).TotalDays;
        Console.WriteLine($"Date is {diff:N0} days ahead.");
    } else if (date == today) {
        Console.WriteLine("Date is today.");
    } else {
        double diff = (today - date).TotalDays;
        Console.WriteLine($"Date is {diff:N0} days behind.");
    }
}