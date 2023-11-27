using System.Net.NetworkInformation;
// Task11();
// Task12();
// Task13();
// Task14();
// Task111();
// Task21();
// Task22();
// Task23();
// Task24();
// TaskProject();

void Task11()
{
    Console.WriteLine("Enter how many numbers are going to input:");
    var numberAmount = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var numberArray = new int[numberAmount];
    for (var index = 0; index < numberArray.Length; index++)
    {
        Console.WriteLine("Enter your number(Separate by enter):");
        numberArray[index] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }
    Console.WriteLine(Task11Sum(numberArray));
}
void Task12()
{
    Console.WriteLine("Enter how many numbers are going to input:");
    var numberAmount = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var numberArray = new int[numberAmount];
    for (var index = 0; index < numberArray.Length; index++)
    {
        Console.WriteLine("Enter your number(Separate by enter):");
        numberArray[index] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }
    Task12PosNeg(out int[] list, numberArray);
    foreach (var num in list)
    {
        Console.WriteLine("Positive numbers: " + num);
    }
    Console.WriteLine("Positive numbers: " + list);
}
void Task13()
{
    Console.WriteLine("Enter how many numbers are going to input:");
    var numberAmount = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    double[] numberArray = new double[numberAmount];
    for (var index = 0; index < numberArray.Length; index++)
    {
        Console.WriteLine("Enter your number(Separate by enter):");
        numberArray[index] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }
    double vatAmount = Task13Vat(numberArray);
    Console.WriteLine("VAT 15% : " + vatAmount);
}
void Task14()
{
    Console.WriteLine("Enter your text:");
    var array = Task14StringArray(Console.ReadLine() ?? throw new InvalidOperationException());
    foreach (var word in array)
    {
        Console.Write(word + " ");
    }
    
}
void Task111()
{
    string[] name = { "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
    string[] type = { "Hearts", "Diamonds", "Spades", "Clubs"};
    PrintCardDeck(ConstructDeck(type, name));
}
void Task21()
{
    Console.WriteLine("Enter numbers of rows");
    var rows = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("Enter numbers of columns");
    var columns = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    int[,] array = new int[rows,columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            Console.WriteLine("Enter number block of:"+ i + " " + j );
            array[i, j] = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        }
    }
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            Console.Write(array[i, j]+ "\t");
        }
        Console.WriteLine();
    }
}
void Task22()
{ 
    int[,] array =
    {
        { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
        { 30, 20, 30, 4, 50, 60, 7, 80, 90, 1, 20, 30, 40, 50, 6, 70, 80, 9, 10 }
    };
    FindRepeatedNumbersInMatrix(array);
}
void Task23()
{
    string[] values1 = new[] { "John", "Marius", "Don", "" };
    string[] values2 = new[] { "John", "Darius", "Allan" };
    int rows = 2;
    int columns = 3;
    string[,] array = new string[2,3];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == 0)
            {
                array[i, j] = values1[j];
            }
            if (i == 1)
            {
                array[i, j] = values2[j];
            }
        }
    }
    FindRepeatedNamesInMatrix(array);
}
void Task24()
{
    int[,] arrayA =
    {
        {1,2,3},
        {1,2,3},
        {1,2,3}
    };
    int[,] arrayB =
    {
        {1,2,3}
    };
    var row = 3;
    var column = 3;
    for (var i = 0; i < row; i++)
    {
        for (var j = 0; j < column; j++)
        {
            arrayA[i, j] *= arrayB[0, j];
        }
    }
    for (var i = 0; i < row; i++)
    {
        for (var j = 0; j < column; j++)
        {
            Console.Write(arrayA[i, j]+"\t");
        }
        Console.WriteLine();
    }
}
void TaskProject()
{
    Console.WriteLine("Welcome to tic tac toe game:");
    Console.WriteLine("Please select option(1.New Game, 2.Exit):");
    var falseSelection = false;
    while (falseSelection == false)
    {
        var firstMenuSelection = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        switch (firstMenuSelection)
        {
            case 1 :
                OpponentSelection();
                falseSelection = true;
                break;
            case 2 :
                Console.WriteLine("Sad we will quit the game");
                falseSelection = true;
                break;
            default:
                Console.WriteLine("Wrong selection");
                break;
        }
    }
}

int Task11Sum(int[] numberArray)
{
    var sum = 0;
    foreach (var number in numberArray)
    {
        sum += number;
    }
    return sum;
}
void Task12PosNeg(out int[]list, int[] array)
{
    var arrayLength = 0;
    var count = 0;
    foreach (var numbers in array)
    {
        if (numbers >= 0)
        {
            arrayLength++;
        }
    }
    list = new int[arrayLength];
    foreach (var num in array)
    {
        if (num >= 0)
        {
            list[0] = num;
            count++;
        }
    }
}
double Task13Vat(double[] array)
{
    double result = 0;
    foreach (var number in array)
    {
        result += number;
    }
    Console.WriteLine(result/100*15);
    return result/100*15;
}
Array Task14StringArray(string text)
{
    string[] textArray = text.Split(" ");
    string[] newArray = new string[textArray.Length];
    for (int i = 0; i < textArray.Length; i++)
    {
        if (textArray[i].Length >= 5)
        {
            newArray[i] += textArray[i];
        }
    }

    return newArray;
}
string[,] ConstructDeck(string[] type, string[] name)
{
    var cardDeck = new string[type.Length,name.Length];
    for (var i = 0; i < type.Length; i++)
    {
        for (var j = 0; j < name.Length; j++)
        {
            cardDeck[i, j] = name[j] + " of " + type[i];
        }
    }
    return cardDeck;
}
void PrintCardDeck(string[,] array)
{
    var nameLength = 6;
    var typeLength = 4;
    for (var i = 0; i < typeLength; i++)
    {
        for (var j = 0; j < nameLength; j++)
        {
            Console.Write(array[i, j].PadRight(25));
        }
        Console.WriteLine();
    }
}
void FindRepeatedNumbersInMatrix(int[,] array)
{
    var rows = 2;
    var columns = 19;
    Console.Write("Repeating numbers are: ");
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            if (array[0, j] == array[1, j])
            {
                Console.Write(array[i, j] + ",");
            }
        }
        break;
    }
}
void FindRepeatedNamesInMatrix(string[,] array)
{
    var rows = 2;
    var columns = 3;
    Console.Write("Repeating names are: ");
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            if (array[0, j].ToLower().Trim() == array[1, j].ToLower().Trim())
            {
                Console.Write(array[i, j] + ",");
            }
        }

        break;
    }
}
void OpponentSelection()
{
    Console.WriteLine("Please select opponent(1.Two Players, 2.vs Computer):");
    var falseSelection = false;
    while (falseSelection == false)
    {
        var firstMenuSelection = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        switch (firstMenuSelection)
        {
            case 1 :
                TwoPlayers();
                falseSelection = true;
                break;
            case 2 :
                VersusComputer();
                falseSelection = true;
                break;
            default:
                Console.WriteLine("Wrong selection");
                break;
        }
    }
}
void TwoPlayers()
{
    int[,] array =
    {
        {0,0,0},
        {0,0,0},
        {0,0,0}
    };
    Console.WriteLine("VST");
}
void VersusComputer()
{
   Console.WriteLine("VSC");
}