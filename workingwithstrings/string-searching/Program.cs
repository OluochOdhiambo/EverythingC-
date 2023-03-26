// See https://aka.ms/new-console-template for more information
string str1 = "The quick brown fox jumps over the lazy dog";

// check if string contains
Console.WriteLine($"str1 contains 'Fox': {str1.Contains("Fox")}");
Console.WriteLine($"str1 contains 'fox': {str1.Contains("Fox", StringComparison.CurrentCultureIgnoreCase)}");

// check if string starts with or ends with 
Console.WriteLine($"str1 starts with 'quick': {str1.StartsWith("quick")}");
Console.WriteLine($"str1 ends with 'dog': {str1.EndsWith("dog")}");

// check index position
Console.WriteLine($"str1 has 'The' at index: {str1.IndexOf("the")}");
Console.WriteLine($"str1 has 'The' at index: {str1.IndexOf("the", StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"str1 has 'The' at index: {str1.LastIndexOf("the")}");