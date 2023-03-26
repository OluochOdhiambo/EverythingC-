// See https://aka.ms/new-console-template for more information
string[] numStrs = {" 1", "1.50", "-100", "5e+04"};

int testint;
float testfloat;
bool result;

// try parse
foreach (string str in numStrs) {
    try{
        testfloat = float.Parse(str);
        Console.WriteLine($"{testfloat}");
        testint = int.Parse(str);
        Console.WriteLine($"{testint}");
    }
    catch (FormatException exception) {
        Console.WriteLine($"{exception.Message}");
    }
}


// alternatively tryParse
result = int.TryParse(numStrs[1], out testint);
Console.WriteLine($"parsed: {result} --- {numStrs[0]} --- {testint}");
