// See https://aka.ms/new-console-template for more information
string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};


// get length
// Console.WriteLine($"str1 length: {str1.Length}");

// access individual characters
// Console.WriteLine($"The 5th character in str1 is: {str1[4]}");

// iterate over string
// foreach (char c in str1) {
//     Console.Write(c);
//     if (c == 'b') {
//         break;
//     }
// }

// concatenate string
// string outsr;
// outsr = String.Concat(strs);
// Console.WriteLine(outsr);

//  join strings with JOIN
// outsr = String.Join('.', strs);
// Console.WriteLine(outsr);

// outsr = String.Join("---", strs);
// Console.WriteLine(outsr);

// string comparison
bool isEqual = str2.Equals(str3);
Console.WriteLine($"str2 is equal to str3: {isEqual}");

// compare: performs ordinal comparison and returns a number
// < 0 : first string comes before second in sort order
// < 0 : first string and second are in same position in sort order
// < 0 : first string comes after second in sort order
int result = String.Compare(str2, "This is a string");
Console.WriteLine($"{result}");

// replace item 
string outsr = str1.Replace("fox", "wolf");
Console.WriteLine(outsr);