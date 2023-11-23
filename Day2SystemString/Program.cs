// Uncomment to run selected task

// Task1();
// Task2();
// Task3();

void Task1()
{
    const string text = "some text";
    Console.WriteLine("Enter number it will show letter in nth place and text lenght:");
    string selection = Console.ReadLine() ?? throw new InvalidOperationException();
    Console.WriteLine("Letter is: " + text[int.Parse(selection)]);
    Console.WriteLine("Text lenght: "+text.Length);
}

void Task2()
{
    string s = "";
    string h = "My name is unknown";
    string full = s + Console.ReadLine();
    Console.WriteLine("From full text taking only name value and \"My\" value");
    Console.WriteLine("Full text:" + full);
    Console.WriteLine("Substring: " + full.Substring(11));
    Console.WriteLine(full.Substring(0,3));
}

void Task3()
{
    Console.WriteLine("Testing .Substring(), .Replace(), .IndexOf(), .Trim(), .ToLowerInvariant(), ToUpperInvariant() methods");
    const string texts = "Hi my name is Unknown";
    Console.WriteLine(texts.Substring(2));
    Console.WriteLine(texts.Replace('i','a'));
    Console.WriteLine(texts.IndexOf("a", StringComparison.Ordinal));
    Console.WriteLine(texts.Trim('n'));
    Console.WriteLine(texts.ToLowerInvariant());
    Console.WriteLine(texts.ToUpperInvariant());
}