using System.Collections;
// Task11();
// Task12();
// Task13();
// Task14();
// Task21();
// Task22();
// Task23();
// Task31();
// Task32();
// Task33();
// Task34();

void Task11()
{
    // parsing variables
    Console.WriteLine("Enter number how many numbers you are going to input: ");
    int arrayLength = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    int[] passedArray = new int[arrayLength];
    for (var i = 0; i < arrayLength; i++) // passedArray.Length;
    {
        Console.WriteLine("Enter your number(Separate by pressing enter)");
        passedArray[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }

    Console.WriteLine("Enter number for power: ");
    var parameter = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

// printing original values
    for (var index = 0; index < passedArray.Length; index++)
    {
        var passedArrayNumber = passedArray[index];
        Console.Write(" " + passedArrayNumber);
    }

    Console.WriteLine();

// printing powered values
    foreach (var newArrayNumber in ArrayTask11(parameter, passedArray))
    {
        Console.Write(" " + newArrayNumber);
    }
}
void Task12()
{
    // parsing variables
    Console.WriteLine("Enter number how many numbers you are going to input: ");
    var arrayLength = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var passedArray = new int[arrayLength];
    for (var i = 0; i < arrayLength; i++)
    {
        Console.WriteLine("Enter your number(Separate by pressing enter)");
        passedArray[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }
    // printing original values
    for (var index = 0; index < passedArray.Length; index++)
    {
        var passedArrayNumber = passedArray[index];
        Console.Write(" " + passedArrayNumber);
    }

    Console.WriteLine();
    Console.WriteLine(ArrayTask12(passedArray));
}
void Task13()
{
    // parsing variables
    Console.WriteLine("Enter number how many numbers you are going to input: ");
    var arrayLength = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var passedArray = new int[arrayLength];
    for (var i = 0; i < arrayLength; i++)
    {
        Console.WriteLine("Enter your number(Separate by pressing enter)");
        passedArray[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }
    // printing original values
    for (var index = 0; index < passedArray.Length; index++)
    {
        var passedArrayNumber = passedArray[index];
        Console.Write(" " + passedArrayNumber);
    }

    Console.WriteLine();
    Console.WriteLine(ArrayTask13(passedArray));
}
void Task14()
{
    // parsing variables
    Console.WriteLine("Enter number how many numbers you are going to input: ");
    var arrayLength = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var passedArray = new int[arrayLength];
    for (var i = 0; i < arrayLength; i++)
    {
        Console.WriteLine("Enter your number(Separate by pressing enter)");
        passedArray[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }
    
    // printing original values
    foreach (var passedArrayNumber in passedArray)
    {
        Console.Write(" " + passedArrayNumber);
    }
    Console.WriteLine();
    
    // printing powered values
    foreach (var newArrayNumber in ArrayTask14(passedArray))
    {
        Console.Write(" " + newArrayNumber);
    }
}
void Task21()
{
    Console.WriteLine("Enter your text:");
    var text = Console.ReadLine();
    for (var index = 0; index < ArrayTask21(text ?? throw new InvalidOperationException()).Length; index++)
    {
        Console.WriteLine(text[index]);
    }

}
void Task22()
{
    Console.WriteLine("Enter your text:");
    var text = Console.ReadLine();
    Console.WriteLine(ArrayTask22(text ?? throw new InvalidOperationException()));
}
void Task23()
{
        Console.WriteLine("Enter your text:");
    var text = Console.ReadLine();
    Console.WriteLine(ArrayTask23(text ?? throw new InvalidOperationException()));
}
void Task31()
{
    // parsing variables
    Console.WriteLine("Enter number how many numbers you are going to input: ");
    var arrayLength = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var passedArray = new int[arrayLength];
    for (var i = 0; i < arrayLength; i++) // passedArray.Length;
    {
        Console.WriteLine("Enter your number(Separate by pressing enter)");
        passedArray[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }

    for (var index = 0; index < passedArray.Length; index++)
    {
        var number = passedArray[index];
        Console.Write(number);
    }

    Console.WriteLine();
    foreach (var number in ArrayTask31(passedArray))
    {
        Console.Write(number);
    }

}
void Task32()
{
    // parsing variables
    Console.WriteLine("Enter number how many numbers you are going to input: ");
    var arrayLength = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var passedArray = new int[arrayLength];
    for (var i = 0; i < arrayLength; i++) // passedArray.Length;
    {
        Console.WriteLine("Enter your number(Separate by pressing enter)");
        passedArray[i] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }

    for (var index = 0; index < passedArray.Length; index++)
    {
        var number = passedArray[index];
        Console.Write(number);
    }

    Console.WriteLine();
    foreach (var number in ArrayTask32(passedArray))
    {
        Console.Write(number);
    }

}
void Task33()
{
    var array = Array.Empty<int>() ;
    Console.WriteLine("Enter number to insert into array: ");
    var ints = ArrayTask33(int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()), array);
    for (var index = 0; index < ints.Length; index++)
    {
        var number = ints[index];
        Console.WriteLine(number);
    }
}
void Task34()
{
    var array = new []{ 1,2,3,4,5,6,7,8,9,10};
    Console.WriteLine("To delete enter index of number in array");
    var ints = ArrayTask34(int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()), new Array[] { array });
    Console.WriteLine(ints);
    for (var index = 0; index < ints.Length; index++)
    {
        Console.WriteLine(ints[index]);
    }
}

Array ArrayTask11(int parameter,int[] passedArray)
{
    for (var i = 0; i < passedArray.Length; i++)
    {
        passedArray[i] = (int)Math.Pow(passedArray[i],parameter);
    }
    return passedArray;
}
int ArrayTask12(int[] passedArray)
{
    var sum = 0;
    for (var i = 0; i < passedArray.Length; i++)
    {
        sum += passedArray[i];
    }
    return sum;
}
int ArrayTask13(int[] passedArray)
{
    return passedArray.Max();
}
Array ArrayTask14(int[] passedArray)
{
    return passedArray.Reverse().ToArray();
}
char[] ArrayTask21(string text)
{
    var charArray = new char[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        charArray[i] = text[i];
    }
    return charArray;
}
char ArrayTask22(string text)
{
    text = text.Trim();
    char letter = text[0];
    return letter;
}
char ArrayTask23(string text)
{
    text = text.Trim();
    char letter = text.Last();
    return letter;
}
Array ArrayTask31(int[] passedArray)
{
   return passedArray.Order().ToArray();
}
Array ArrayTask32(int[] passedArray)
{
    return passedArray.OrderDescending().ToArray();
}
int[] ArrayTask33(int number, int[] array)
{
    Array.Resize(ref array, array.Length+1);
    array[array.Length-1] = number;
    return array;
}
Array[] ArrayTask34(int number, Array[]? array)
{
    ((IList)array!).RemoveAt(number);
    Array.Resize<Array>(ref array, array.Length);
    return array;
}
