using System.Diagnostics;
using System.Text;
// Task11Mod();
// Task21();
// Task31();
// Task41();
// Task51();
// Task61();
// Task62();
// Task62();
// TaskProject();

void Task11()
{
    Console.WriteLine("Enter three numbers:");
    var a = 10;
    var b = 11;
    var c = 12;
    var max = a;
    if (b > max)
        max = b;
    if (c > max)
        max = c; // mistake is there, instead max = b it should be max = c
    Console.WriteLine("The maximum value is: " + max);
}
void Task11Mod()
{
    Console.WriteLine("Enter three numbers:");
    var a = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var b = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var c = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var max = a; // max is not necessary
    if (b > a) // instead bb > max: b > a
        max = b;
    if (c > a) // instead cc > max: b > a
        max = c; // mistake is there, instead max = b it should be max = c
    Console.WriteLine("The maximum value is: " + max);
}
void Task21()
{
    const string firstName = "John";
    const string lastName = "Doe";
    const string fullName = firstName + " " + lastName; // missing gap between firstName and lastName
    Console.WriteLine("Full name: " + fullName);
}
void Task31()
{
    var counter = 0;
    while (counter <= 10)
    {
        Console.WriteLine("Count: " + counter);
        counter--; // counter should be ++, it makes infinitive loop because counter in each cycle is decremented
    }
}
void Task41()
{
    var i = 5;
    while (i > 0)
    {
        Console.WriteLine(i);
        i--; // counter should be --, it makes infinitive loop because counter in each cycle is incremented
    }
}
void Task51()
{
    const string name1 = "John";
    const string name2 = "john";
    if (name1.Trim().ToLower().Equals(name2.Trim().ToLower())) // Names are same, but there is no string manipulation for upper or lower letter and missing trimming
    {
        Console.WriteLine("Names are the same.");
    }
    else
    {
        Console.WriteLine("Names are different.");
    }
}
void Task61()
{
    // not correct, to fully use string builder need to iterate through all strings. Code is redundant, because string builder parameter is imediatelly converted to string
    Console.WriteLine("Enter your text:");
    var stringBuilder = new StringBuilder(Console.ReadLine());
    Console.WriteLine(new string(stringBuilder.ToString().Reverse().ToArray()));
}
void Task62()
{
    Console.WriteLine("Enter your text:");
    var stringBuilder = new StringBuilder(Console.ReadLine());
    var splitStrings = stringBuilder.ToString().Split("");
    var splitStringCharArray = Array.Empty<char>();
    foreach (var character in splitStrings)
    {
        splitStringCharArray = character.Distinct().ToArray();
    }
    var result = string.Join("" , splitStringCharArray);
    stringBuilder.Clear();
    stringBuilder.Append(result);
    Console.WriteLine(result);
}
void TaskProject()
{
    Console.WriteLine("Enter two numbers:");
    var num1 = Convert.ToDouble(Console.ReadLine());
    var num2 = Convert.ToDouble(Console.ReadLine());

    // Direct
    var stopwatchConcat = Stopwatch.StartNew();
    var directConcatResult = DirectConcatenation(num1, num2);
    stopwatchConcat.Stop();
    Console.WriteLine($"Direct Concatenation Result:\n{directConcatResult}");
    Console.WriteLine($"Direct Concatenation Time: {stopwatchConcat.ElapsedMilliseconds}ms");

    // String builder
    var stopwatchBuilder = Stopwatch.StartNew();
    var stringBuilderResult = UsingStringBuilder(num1, num2);
    stopwatchBuilder.Stop();
    Console.WriteLine($"\nUsing StringBuilder Result:\n{stringBuilderResult}");
    Console.WriteLine($"Using StringBuilder Time: {stopwatchBuilder.ElapsedMilliseconds}ms");

    Console.ReadLine();
}

static string DirectConcatenation(double num1, double num2)
{
    var result = "";
    result += $"Sum: {Add(num1, num2)}\n";
    result += $"Difference: {Subtract(num1, num2)}\n";
    result += $"Product: {Multiply(num1, num2)}\n";

    if (num2 != 0)
        result += $"Quotient: {Divide(num1, num2)}\n";
    else
        result += "Cannot divide by zero!\n";

    return result;
}
static string UsingStringBuilder(double num1, double num2)
{
    var output = new StringBuilder();

    output.AppendLine($"Sum: {Add(num1, num2)}");
    output.AppendLine($"Difference: {Subtract(num1, num2)}");
    output.AppendLine($"Product: {Multiply(num1, num2)}");

    if (num2 != 0)
        output.AppendLine($"Quotient: {Divide(num1, num2)}");
    else
        output.AppendLine("Cannot divide by zero!");

    return output.ToString();
}
static double Add(double a, double b)
{
    return a + b;
}
static double Subtract(double a, double b)
{
    return a - b;
}
static double Multiply(double a, double b)
{
    return a * b;
}
static double Divide(double a, double b)
{
    return b != 0 ? a / b : double.NaN;
}