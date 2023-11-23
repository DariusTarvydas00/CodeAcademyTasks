using System.Diagnostics.Contracts;

// Task11();
// Task12();
// Task13();
// Task21();
// Task22();
// Task23();
// Task24();
// Task31();
// Task32();

void Task11()
{
    Console.WriteLine("Enter password: if password lenght is more then 8 it will show true, else false");
    Console.WriteLine(IsPasswordValid(Console.ReadLine() ?? throw new InvalidOperationException()));
}
void Task12()
{
    Console.WriteLine("Enter email: if it contains '@' and '.' it will show true, else false");
    Console.WriteLine(IsEmailValid(Console.ReadLine() ?? throw new InvalidOperationException()));
}
void Task13()
{
    Console.WriteLine("Enter dollars amount to convert to Euros: ");
    Console.WriteLine(ConvertToEuros(double.Parse(Console.ReadLine() ?? throw new InvalidOperationException())));
}
void Task21()
{
    Console.WriteLine("Enter name, then surname: ");
    Console.WriteLine(GetInitials(
        Console.ReadLine() ?? throw new InvalidOperationException(),
        Console.ReadLine() ?? throw new InvalidOperationException()));  
}
void Task22()
{
    Console.WriteLine("Enter cylinder radius, then height to calculate volume: ");
    Console.WriteLine(CalculateCylinderVolume(
        double.Parse(Console.ReadLine() ?? throw new InvalidOperationException()),
        double.Parse(Console.ReadLine() ?? throw new InvalidOperationException())));
}
void Task23()
{
    Console.WriteLine("Enter number to check if number is Even: "); 
    Console.WriteLine(IsNumberEven(
        int.Parse(Console.ReadLine() ?? throw new InvalidOperationException())));
}
void Task24()
{
    Console.WriteLine("Enter rectangle length, then width to calculate area: ");
    Console.WriteLine(CalculateRectangleArea(
        double.Parse(Console.ReadLine() ?? throw new InvalidOperationException()),
        double.Parse(Console.ReadLine() ?? throw new InvalidOperationException())));
}
void Task31()
{ 
    Console.WriteLine("Enter number for factorial calculation:");
    var factNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Factorial(factNumber);  
}
void Task32()
{
    Console.WriteLine("Enter number for max fibonacci sequence:");
    Console.WriteLine(Fibonacci(int.Parse(Console.ReadLine() ?? throw new InvalidOperationException())));
}

bool IsPasswordValid(string password)
{
    return password.Length > 8;
}
bool IsEmailValid(string email)
{
    if (email.Contains('@')&&email.Contains('.'))
    {
        if (email.IndexOf('@') < email.IndexOf('.'))
        {
            return true;
        }
    }
    return false;

}
double ConvertToEuros(double dollars)
{
    const double rate = 0.92;
    return rate * dollars;
}
string GetInitials(string firstName, string lastName)
{
    return new string(firstName + " " + lastName);
}
double CalculateCylinderVolume(double radius, double height)
{
    return Math.PI * radius * radius * height;
}
bool IsNumberEven(int number)
{
    return number % 2 == 0;
}
double CalculateRectangleArea(double length, double width)
{
    return length * width;
}
int Factorial(int number)
{
    if (number <= 0)
    {
        return 1;
    }
    return number * (Factorial(number - 1));
}
int Fibonacci(int number)
{
    if (number <= 1) return number;
    return Fibonacci(number - 1) + Fibonacci(number - 2);
}

