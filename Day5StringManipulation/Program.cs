using System.Linq.Expressions;
// Task11();
// Task12();
// Task13();
// Task21();
// Task22();
// Task23();
// Task31();
// Task32();
// Task33();
Task4();
Task5();
Task6();
Task7();
void Task11()
{
    Console.WriteLine("Enter text the first letter of the sentence will be replaced with capital letter");
    string text11 = Console.ReadLine() ?? throw new InvalidOperationException();
    string toUpper = text11.Substring(0,1).ToUpperInvariant();
    text11 = text11.Remove(0, 1);
    Console.WriteLine(toUpper+text11);
}
void Task12()
{
    Console.WriteLine("Enter text and it will replace numbers or at location to corresponding text:(2-g,4-b,6-*,8-x,10-w)");
    string text12 = Console.ReadLine() ?? throw new InvalidOperationException();
    Console.WriteLine(text12.Remove(2, 1).Insert(2, "g")
        .Remove(4, 1).Insert(2, "b")
        .Remove(6, 1).Insert(2, "*")
        .Remove(8, 1).Insert(2, "x")
        .Remove(10, 1).Insert(2, "w"));
    
    Console.WriteLine(text12
        .Replace("2","g")
        .Replace("4","b")
        .Replace("6","*")
        .Replace("8","x")
        .Replace("10","w"));
}
void Task13()
{
    Console.WriteLine("Enter text it will check if entered less or more then 5 and by user choose it will be encoded ");
    Console.WriteLine("Enter text:");
    var text13 = Console.ReadLine();
    if (text13 != null && text13.Length > 5)
        Console.WriteLine("Entered text contains more then 5 characters");
    else
        Console.WriteLine("Entered text contains less then 5 characters");

    Console.WriteLine("Enter char for encoding:");
    char encoding13 = char.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

    if (text13 != null)
    {
        char[] textArray = text13.ToCharArray();
        for (int i = 0; i < textArray.Length; i++)
        {
            textArray[i] = (char)(textArray[i] + encoding13);
            i++;
        }

        string newText = new string(textArray);
        Console.WriteLine($"New encoded text:{newText}");
    }
}
void Task21()
{
    Console.WriteLine("Enter sentence (All letters from a will be replaced to uo, and all letters from i will be replaced to e):");
    Console.WriteLine(Console.ReadLine()?.Replace("a","uo").Replace("i","e"));
}
void Task22()
{
    Console.WriteLine("Enter lyric or poem (your chosen word will be replaced to another word by your choose):");
    string sentence22 = Console.ReadLine() ?? throw new InvalidOperationException();
    Console.WriteLine("Enter which word you want to replace to another");
    string selectedWord = Console.ReadLine() ?? throw new InvalidOperationException();
    Console.WriteLine("Enter to what word you want to replace selected word");
    string replacement = Console.ReadLine() ?? throw new InvalidOperationException();
    Console.WriteLine(sentence22.Replace(selectedWord,replacement));
}
void Task23()
{
    Console.WriteLine("Enter your age:");
    var age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine($"For you is left until 90 years: {90-age} years; {(90-age)*12} months; {(90-age)*365} days; or {(90-age)*48} weeks");
}
void Task31()
{
    Console.WriteLine("Enter text, if text first letter is capital the word will be replaced in all capitals, otherwise only first letter will be replaced in capital");
    string text31 = Console.ReadLine() ?? throw new InvalidOperationException();
    if (char.IsUpper(text31[0]))
    {
        text31 = text31.ToUpperInvariant();
        Console.WriteLine(text31);
    }
    else
    {
        char letter = char.ToUpper(text31[0]);
        text31 = letter + text31.Remove(0, 1);
        Console.WriteLine(text31);
    }
}
void Task32()
{
    Console.WriteLine("Enter text it will check if it contains letter 'a' if yes it it will print word together with the index of the character 'a'. Otherwise it will print 'Character 'a' not found'");
    var text = Console.ReadLine();
    if (text != null && text.ToLower().Contains('a'))
    {
        Console.WriteLine(text + "Character a index of is:" + text.IndexOf('a'));
    }
    else
    {
        Console.WriteLine("Character 'a' not found");
    }
}
void Task33()
{
    Console.WriteLine("Enter word: it will check if it is word 'hello'. If it is it will print it backwards using Reverse() method, else it will print your entered word");
    var word = Console.ReadLine();
    if (word != null && word.ToLowerInvariant() == "hello")
    {
        var charArray = word.ToCharArray();
        Array.Reverse(charArray);
        var word2 = new string(charArray);
        Console.WriteLine(word2);
    }
    else
    {
        Console.WriteLine(word);
    }
}
void Task4()
{
    Console.WriteLine("Subway sandwich maker app");
    Console.WriteLine("Answer following questions in order to make your perfect sandwich:");
    Console.WriteLine("What kind of bread you would like for your sandwich? (white, wholewheat, rye, multigrain or baguette?)");
    
    while (int.TryParse(Console.ReadLine(), out int n))
    {
        
    }
    
}

void Task5()
{
}

void Task6()
{
}

void Task7()
{
}

//
//
//
// void Task111()
// {
//     Console.Write("Enter the phone number: separate the code with -");
//     string phoneNumber = Console.ReadLine();
//
//     string pFrom = phoneNumber.Trim('+');
//     Console.WriteLine(pFrom);
//     int bruksnioVieta = pFrom.IndexOf('-');
//
//     char asd = Console.ReadKey().KeyChar;
//     int paskutiniIndeksas = pFrom.Length - 3;
//     
//     Console.WriteLine(bruksnioVieta);
//     Console.WriteLine(paskutiniIndeksas);
//     Console.WriteLine(pFrom);
//     pFrom = pFrom.Remove(bruksnioVieta, paskutiniIndeksas);
//     Console.WriteLine(pFrom);
//
//     //string countryCode = phoneNumber.IndexOf('+').ToString;
//     Console.WriteLine($"The phone number code is {pFrom}.");
//
//     switch (pFrom)
//     {
//         case "370":
//             Console.WriteLine("LT");
//             break;
//     }
//
//     Console.Write("how many minutes will be spoken: ");
//     string minutesSpoken = Console.ReadLine();
//     Console.WriteLine($"Call to number: {phoneNumber}");
//     Console.WriteLine($"Call time: {minutesSpoken}");
//     Console.WriteLine($"Call price per minute: X/1min");
//     Console.WriteLine($"Final call price: €XX.XX.");
//
//
//
//
//
//
//
//
//
// // Console.WriteLine("Enter text(first letter in sentence will become capital)");
//     // string textttt = "+370-123456";
//     // // Console.WriteLine(textttt.Split("+").ToString());
//     // // Console.WriteLine(textttt.Split("-").ToString());
//     // textttt.Trim('+');
//     // string str = textttt.Substring(5,textttt.Length-1);
//     // Console.WriteLine(str);
//     // string text11 = Console.ReadLine() ?? throw new InvalidOperationException();
//     // Console.WriteLine(char.ToUpper(text11[0]) + text11.Substring(1));
// }