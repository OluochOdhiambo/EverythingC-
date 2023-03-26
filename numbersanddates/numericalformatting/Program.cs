// See https://aka.ms/new-console-template for more information
int[] quaters = {1,2,3,4};
int[] sales = {100000, 200000, 300000, 335000};
double[] intlMixPct = {.386, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;

// Numerical formatting
// General format {index[,alignment]:[format]}
// Common types N, G, F, E, D, P, X, C

// Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}");
// Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}");

// formatting with alignment
Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quaters[0],12} {quaters[1],12} {quaters[2],12} {quaters[3],12}");
Console.WriteLine($"{sales[0],12:C0} {sales[1],12:C0} {sales[2],12:C0} {sales[3],12:C0}");
Console.WriteLine("International Sales:");
Console.WriteLine($"{intlMixPct[0],12:P2} {intlMixPct[1],12:P2} {intlMixPct[2],12:P2} {intlMixPct[3],12:P2}");