using System.Text;
// Task11();
// Task12();
// Task13();
// Task21();
// Task22();
// Task23();

void Task11()
{
    var strings = new List<string>
    {
        "One",
        "Two",
        "Three"
    };
    Task11PrintList(strings);
}
void Task12()
{
    var numbers = new List<int>();
    Task12FillAndReturnAvg(numbers);
}
void Task13()
{
    var list = new List<int>();
    var random = new Random();
    for (var i = 0; i < 50; i++)
    {
        list.Add(random.Next(-50,50));
    }
    foreach (var num in Task13ReturnGreater(list))
    {
        Console.WriteLine(num);
    }
}
void Task21()
{
    var list = new List<string>()
    {
        "a",
        "One",
        "Two",
        "Three",
        "Four",
        "Five",
        "Six",
        "Seven"
    };
    foreach (var word in Task21ReturnsWordSum(list))
    {
        Console.WriteLine(word);
    }
}
void Task22()
{
    var list = new List<int>(){1,2,3,4,5,6,7,8,9,10};
    foreach (var num in Task22Factorial(list))
    {
        Console.WriteLine(num);
    }
}
void Task23()
{
    var list = new List<string>()
    {
        "A",
        "AA",
        "AAA",
        "AAAA"
    };
    var isPrimeList = Task23IsPrime(list);
    Console.WriteLine("Words which are prime are: ");
    foreach (var text in isPrimeList)
    {
        Console.WriteLine(text);
    }
}

void Task11PrintList(List<string> strings)
{
    foreach (var text in strings)
    {
        Console.WriteLine(text.Length);
    }
}
void Task12FillAndReturnAvg(List<int> numbers)
{
    Console.WriteLine(Task12ReturnAvg(Task12FillList(numbers)));
}
List<int> Task12FillList(List<int> numbers)
{
    var random = new Random();
    for (var i = 0; i < 50; i++)
    {
        numbers.Add(random.Next(1,100));
    }
    return numbers;
}
double Task12ReturnAvg(List<int> newList)
{
    return newList.Average();
}
List<int> Task13ReturnGreater(List<int> list)
{
    return list.Where(num => num > 10).ToList();
}
List<string> Task21ReturnsWordSum(List<string> list)
{
    var newList = new List<string>();
    foreach (var word in list)
    {
        var asciiBytes = Encoding.ASCII.GetBytes(word);
        var total = 0;
        Array.ForEach(asciiBytes, delegate (byte i) { total += i; });
        if (total % 2 == 0)
        {
            newList.Add(word);
        }
    }

    return newList;
}
List<int> Task22Factorial(List<int> list)
{
    var newList = new List<int>();
    foreach (var num in list)
    {
        int i;
        var fact = num;
        for (i = num - 1; i >= 1; i--)
        {
            fact *= i;
        }
        newList.Add(fact);
    }

    return newList;
}
List<string> Task23IsPrime(List<string> list)
{
    var newList = new List<string>();
    foreach (var word in list)
    {
        var count = 0;
        for (var i = 0; i < word.Length; i++)
        {
            count++;
        }

        if (IsPrime(count))
        {
            newList.Add(word);
        }
    }

    return newList;
}
bool IsPrime(int number)
{
    if (number <= 1)
        return false;

    for (var i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
            return false;
    }

    return true;
}