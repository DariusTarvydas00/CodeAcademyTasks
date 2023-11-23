// Task11();
// Task12();
// Task13();
// Task21();
// Task22();
// Task23();

void Task11()
{
    var x = 10;
    var y = 20;
    Console.WriteLine(x + " " + y);
    Swap(ref x,ref y);
    Console.WriteLine(x + " " + y);
}
void Task12()
{
    var x = 1;
    var y = 10;
    Console.WriteLine(x + " " + y);
    IncrementByN(ref x,ref y);
    Console.WriteLine(x);
}
void Task13()
{
    var someText = "there is some text";
    TrimAndCapitalize(ref someText);
    Console.WriteLine(someText);
}
void Task21()
{
    GetUserData(out var firstName, out var surName);
    Console.WriteLine(firstName + " " + surName);
}
void Task22()
{
    NumberGreaterThen100(out var conversionSuccessful, out var number);
    Console.WriteLine("Conversion value is: "+conversionSuccessful + " Your entered number was: " + number);
}
void Task23()
{
    Console.WriteLine("Enter Dividend:");
    var number1 = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("Enter Quotient:");
    var number2 = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var trueOrFalse = Divide( number1,  number2, out var result, out var quotientResult);
    Console.WriteLine(result.ToString("0.00") + " " + quotientResult.ToString("0.00") + " Is it possible to divide: " + trueOrFalse);
}

void Swap(ref int x, ref int y)
{
    (x, y) = (y, x);
}
void IncrementByN(ref int value, ref int increment)
{
    value += increment;
}
void TrimAndCapitalize(ref string text)
{
    text = text.Trim();
    text = text.Remove(0, 1).Insert(0,char.ToUpper(text[0]).ToString());
}
void GetUserData(out string firstName, out string surName)
{
    Console.WriteLine("Enter your first name:");
    firstName = Console.ReadLine() ?? throw new InvalidOperationException();
    Console.WriteLine("Enter your Surname");
    surName = Console.ReadLine() ?? throw new InvalidOperationException();
}
void NumberGreaterThen100(out bool conversionSuccessful, out int number)
{
    number = 0;
    conversionSuccessful = false;
    Console.WriteLine("Enter your number to check if it is greater then 100:");
    while (int.TryParse(Console.ReadLine(), out number))
    {
        if (number > 100)
        {
            conversionSuccessful = true;
            break;
        }
        Console.WriteLine("Conversion value is: "+conversionSuccessful + " Your entered number was: " + number);
    }
}
bool Divide(double number1, double number2, out double result, out double quotientResult)
{
    quotientResult = 0;
    result = 0;
    if (number2 == 0)
    {
        Console.WriteLine($"Division not possible:(Your quotient is: {number2})");
        return false;
    }
    result = number1 / number2;
    quotientResult = number1 % number2;
    return true;
}