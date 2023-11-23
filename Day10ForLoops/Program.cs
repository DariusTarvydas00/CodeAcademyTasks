



Task12();
Task11();
Task11Mod();
// Task12();
// Task13();
// Task13Mod();
// Task14();
// Task15();
// Task15Mod();
// Task16();

void Task11()
{
    for (var i=0; i<=100; i+=2)
    {
            Console.WriteLine(i);
    }
}
void Task11Mod()
{
    for (var i=0; i<=100; i+=2)
    {
        for (var j = i; j % 2 == 0; j++)
        {
            Console.WriteLine(i);
        }
    }
}
void Task12()
{
    Console.WriteLine("Enter number for sum");
    var temp = 0;
    for (var i = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()); i > 0; i--)
    {
        Console.WriteLine(temp += i);
    }
}
void Task13()
{
    Console.WriteLine("Enter number:");
    for (var i = 0; i <= int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()); i++)
    {
        Console.Write(i*i);
        Console.WriteLine(" " + Math.Pow(i,2));
    }
}
void Task13Mod()
{
    Console.WriteLine("Enter number for n squares:");
    for (var i = 0; i <= int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()); i++)
    {
        for (var j = 0; j < 4; j++)
        {
            for (var k = 0; k < 4; k++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            
        }
        for (var k = 0; k < 4; k++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}
void Task14()
{
    Console.WriteLine("Enter number for sum");
    var input = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    double temp = 0;
    for (var i = input; i >=0; i--)
    { 
        temp += i;
    }
    Console.WriteLine(temp/input);
}
void Task15()
{
    Console.WriteLine("Enter number for sum");
    for (var i = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()); i >0; i--)
    {
        Console.WriteLine("********");
    }
}
void Task15Mod()
{
    Console.WriteLine("Enter number for sum");
    var input = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    for (var i = input; i > 0; i--)
    {
        for (var j = input; j > 0; j--)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
void Task16()
{
    for (var i = 0; i < 100; i++)
    {
        for (var j = i; j%3 == 0; j++)
        {
            Console.WriteLine(j);   
        }
        for (; i % 3 == 0; )
        {
            Console.WriteLine(i);
            break;
        }
    }
}