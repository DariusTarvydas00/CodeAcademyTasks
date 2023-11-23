using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
// Task11();
// Task12();
// Task13();
// Task14();
// Task15();
// Task16();
// Task21();
// Task23();
// Task24();
// Task31();
// Task32();
// Task33();
// Task41();
// Task42();
// Task51();
// Task52();
// Task53();
Task61();

void Task11()
{
    var i = 1;
    while (i<=5)
    {
        Console.WriteLine(i);
        i++;
    }
}
void Task12()
{
    int i = 1;
    while (i<=5)
    {
        Console.WriteLine(i);
        i++;
        int j = 5;
        while (j>=1)
        {
            Console.WriteLine(j);
            j--;
        }
    }
}
void Task13()
{
    int i = 2;
    while (i<=10)
    {
        if (i%3 == 0)
            Console.WriteLine($"Even number:{i}");
        i++;
    }
}
void Task14()
{
    int i = 2;
    while (i<=10)
    {
        if (i%2 == 0)
            Console.WriteLine($"First loop number:{i}");
        int j = 1;
        while (j<=9)
        {
            if (j%3 == 0)
                Console.WriteLine($"Second loop number:{j}");
            j++;
        }

        i++;
    }
}
void Task15()
{
    const int greaterThen100 = 100;
    while (int.Parse(Console.ReadLine() ?? throw new InvalidOperationException())<greaterThen100)
    {
        Console.WriteLine("Number is less then 100");
    }
    Console.WriteLine("Finally! Number is greater then 100");
}
void Task16()
{
    const int greaterThen100 = 100;
    var input = -1;
    while (int.Parse(Console.ReadLine() ?? throw new InvalidOperationException())<greaterThen100)
    {
        while (input<0)
        {
            Console.WriteLine("Number is negative");
            input = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()); 
        }
        Console.WriteLine("Number is still less then 100");
    }
    Console.WriteLine("Finally! Number is greater then 100");
}
void Task21()
{
    var number21 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var factorial = number21;
    while (number21 > 1)
    {
        factorial *= number21 - 1;
        number21--;
    }
    Console.WriteLine("Factorial value: " + factorial);
    var number211 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    while (number21 > 1 || number211 < 0)
    {
        number21--;  
    }
}
void Task22()
{
    Console.WriteLine("Enter number for triangle:");
    var digit = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var counter = 1;
    for (var i = 0; i < digit; i++)
    {
        for (var l = 0; l < counter; l++)
        {
            Console.Write("*");
            var number21 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var factorial = number21;
            while (number21 > 1)
            {
                factorial *= number21 - 1;
                number21--;
            }
            Console.WriteLine("Factorial value: " + factorial);
    
            var number211 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            while (number21 > 1 || number211 < 0)
            {
                number21--;  
            }
        }
        Console.WriteLine();
        counter++;
    }
}
void Task23()
{
    Console.WriteLine("Enter number:");
    var number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var numberArray = new List<int>();
    while (number > 0)
    {
        numberArray.Add(number%10);
        number /= 10;
    }
    numberArray.Sort();
    foreach (var digit in numberArray)
    {
        Console.Write(digit);
        Console.Write(", ");
    }
}
void Task24()
{
    Console.WriteLine("Enter number for triangle:");
    var digit = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var counter = 1;

    for (int i = 0; i < digit; i++)
    {
        for (int l = 0; l < counter; l++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        counter++;
    }
}
void Task31()
{
    Console.WriteLine("Enter number:");
    var number = Console.ReadLine();
    while (char.IsDigit(Convert.ToChar(number ?? throw new InvalidOperationException())))
    {
        Console.WriteLine("asd");
    }
    Console.WriteLine("Check if you entering same number:");
    // while (!char.IsDigit(number))
    // {
    //     Console.WriteLine("Entered wrong number");
    //     number = Console.ReadLine();
    // }
    Console.WriteLine("Correct number");
}
void Task32()
{
    Console.WriteLine("Enter number which you want to raise by degree:");
    var numberToRise = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var counter = 5;
    while (counter > 0)
    {
        Console.WriteLine("Enter degree to raise: ");
        var numberOfDegreesToRise = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        numberToRise += numberOfDegreesToRise;
        Console.WriteLine($"Number raised by: {numberToRise}");
        counter--;
    }
}
void Task33()
{
    Console.WriteLine("Enter digit");
    var digit = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("Enter digit how many groups do you want to make:");
    var howManyGroups = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var counter = 1;
    for (int i = 0; i < howManyGroups; i++)
    {
        Console.Write(" -> ");
        for (int l = 0; l < counter; l++)
        {
            Console.Write(digit);
        }
        counter++;
    }
}
void Task41()
{
    Console.WriteLine("Enter digit, it will draw a triangle");
    var digit = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var counter = 0;
    while (counter != digit+1)
    {
        for (int i = 0; i < counter; i++)
        {
            Console.Write(counter);
        }
        Console.WriteLine();
        counter++;
    }
}
void Task42()
{
    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Enter amount to withdraw:");
    var amountToWithdraw = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    var amountArray = new List<int>();
    while (amountToWithdraw>0)
    {
        if (amountToWithdraw - 50 >= 0)
        {
            amountArray.Add(50);
            amountToWithdraw -= 50;
        } 
        else if (amountToWithdraw - 20 >= 0)
        {
            amountArray.Add(20);
            amountToWithdraw -= 20;
        }
        else if (amountToWithdraw - 10 >= 0)
        {
            amountArray.Add(10);
            amountToWithdraw -= 10;
        }
        else if (amountToWithdraw - 5 >= 0)
        {
            amountArray.Add(5);
            amountToWithdraw -= 5;
        }
    }

    foreach (var banknote in amountArray)
    {
        Console.Write($"\u20ac{banknote},");
    }
}
void Task51()
{
    var intArray = new List<int>();
    do
    {
        Console.WriteLine("Enter digit for sum, if finished enter \"Finish\" without double quotes");
        var text = Console.ReadLine();
        if (int.TryParse(text, out var n))
        {
            Console.WriteLine("Number added:" + n);
            intArray.Add(n);
        }
        else if (text != null && text.ToLower() == "finish")
        {
            var sum = intArray.Sum();
            Console.WriteLine("Final sum of all numbers is: "+sum);
            break;
        }
    } while (true);
}
void Task52()
{
    var newPassword = string.Empty;
    var triesLeft = 5;
    if (newPassword == "")
    {
        Console.WriteLine("Enter new password");
        newPassword = Console.ReadLine();
    }

    string text;
    do
    {
        Console.WriteLine("Enter Password you have "+triesLeft+" tries left");
        text = Console.ReadLine() ?? throw new InvalidOperationException();
        triesLeft--;
        if (newPassword != text)
        {
            Console.WriteLine("Incorrect password");
        }
        else
        {
            Console.WriteLine("Correct password");
            break;
        }
    } while (text != newPassword && triesLeft > -1);
    
    // while (counter >= 0 && newPassword == tryPassword)
    // {
    //     if (newPassword == "")
    //     {
    //         Console.WriteLine("Enter new password:");
    //         newPassword = Console.ReadLine();
    //         Console.Clear();
    //     }
    //     else
    //     {
    //         Console.WriteLine("Enter password:");
    //         var tryPassword = Console.ReadLine();
    //         if (tryPassword != newPassword)
    //         {
    //             if (counter != 0)
    //             {
    //                 Console.WriteLine("Wrong password, try again. Left tries:" + counter);
    //             }
    //             else
    //             {
    //                 Console.WriteLine("Blocked, no more tries");
    //             }
    //
    //         }
    //         else
    //         {
    //             Console.WriteLine("You entered correct password");
    //         }
    //     }
    //     counter--;
    // }
}
void Task53()
{
    var random = new Random();
    var randomNumber = random.Next(1, 100);
    var guessNumber = new int();
    do
    {
        Console.WriteLine("Guess the number:");
        guessNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        if (guessNumber > randomNumber)
        {
            Console.WriteLine("Your guessed number is greater then random number");
        }
        if (guessNumber < randomNumber)
        {
            Console.WriteLine("Your guessed number is less then random number");
        }
    } while (guessNumber != randomNumber);
    Console.WriteLine("You guessed right!");
    // while (guessNumber != randomNumber)
    // {
    //     Console.WriteLine("Guess the number:");
    //     guessNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    //     if (guessNumber > randomNumber)
    //     {
    //         Console.WriteLine("Your guessed number is greater then random number");
    //     }
    //     if (guessNumber < randomNumber)
    //     {
    //         Console.WriteLine("Your guessed number is less then random number");
    //     }
    // }
    // Console.WriteLine("You guessed right!");
}

// void Task61()
// {
//     Console.WriteLine("Welcome to Cycle - While project/game." +
//                       "\nTo continue press any button");
//     Console.ReadLine();
//     Console.Clear();
//     Console.WriteLine("In order to start playing, please enter your user name:");
//     var userName = Console.ReadLine();
//     var userHealthPoints = 0;
//     Console.WriteLine("What type of character you would like to choose (write a number which class you have chosen)? (1.Rogue 2.Mage 3.Druid 4.Warlock 5.(default)Warrior )");
//     var classSelection = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
//
//     switch (classSelection)
//     {
//         case 1:
//             userHealthPoints += 500;
//             Console.WriteLine("You have selected Rogue, as an Rogue you have " + userHealthPoints + " Health Points");
//             break;
//         case 2:
//             userHealthPoints += 300;
//             Console.WriteLine("You have selected Mage," + userHealthPoints + " Health Points");
//             break;
//         case 3:
//             userHealthPoints += 700;
//             Console.WriteLine("You have selected Druid," + userHealthPoints + " Health Points");
//             break;
//         case 4:
//             userHealthPoints += 250;
//             Console.WriteLine("You have selected Warlock," + userHealthPoints + " Health Points");
//             break;
//         default:
//             userHealthPoints += 1000;
//             Console.WriteLine("You have selected Warrior," + userHealthPoints + " Health Points");
//             break;
//     }
//     
//     Console.WriteLine("Hello " + userName + ".");
//     Console.WriteLine("Your adventure will start there. Press any button to start the journey.");
//     Console.ReadLine();
//     
//     Console.Clear();
//     while (true)
//     {
//         Console.WriteLine($"Select path to go {userName}:" +
//                           "\n1.Go north to forest" +
//                           "\n2.Go south towards bandit camp" +
//                           "\n3.Go west near by waterfall");
//         var roadSelection = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
//         Console.Clear();
//         switch (roadSelection)
//         { 
//             case 1: 
//                 Console.WriteLine("While going deeper in the forest you met Ogre near by the swamp:"); 
//                 Console.WriteLine("What you are going to do?:" + 
//                                   "\n1.Be brave! and Fight the Ogre" +
//                                   "\n2.I am coward! Run away"); 
//                 var option = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()); 
//                 if (option == 1)
//                 {
//                     var ogreHealth = 100;
//                     var randomOgreAttack = new Random();
//                     Console.WriteLine("You are started fight with Ogre:");
//                     do
//                     {
//                         Console.WriteLine("Choose attack mode:(low,medium,high)");
//                         var attackMode = Console.ReadLine();
//                         switch (attackMode)
//                         {
//                             case "low":
//                                 Console.WriteLine("You tried to punch Ogre in the face(15points):");
//                                 ogreHealth -= 15;
//                                 userHealthPoints -= randomOgreAttack.Next(1, 100);
//                                 break;
//                             case "medium":
//                                 Console.WriteLine("You tried to kick Ogre with feet(25points):");
//                                 ogreHealth -= 25;
//                                 userHealthPoints -= randomOgreAttack.Next(1, 100);
//                                 break;
//                             case "high":
//                                 Console.WriteLine("You tried to push Ogre in the swamp(45points):");
//                                 ogreHealth -= 45;
//                                 userHealthPoints -= randomOgreAttack.Next(1, 100);
//                                 break;
//                         }
//                         if (userHealthPoints > 0)
//                         {
//                         }
//                         if (userHealthPoints <= 0)
//                         {
//                         }
//                     } while (ogreHealth > 0);
//                 }
//                 else
//                 {
//                 } 
//                 break; 
//             default: 
//                 Console.WriteLine("Wrong number entered:"); 
//         }
//     }
// }

void Task61()
{
    // paper,scissor, stone fight 1vs1 until 100 health points becomes 0

    var userHealth = 100;
    var enemyHealth = 100;
    
    var randomEnemyChoose = new Random();
    var randomNumber = randomEnemyChoose.Next(1, 4);
    Console.WriteLine(randomNumber);
    var randomEnemySelection = "";
    randomEnemySelection = randomNumber switch
    {
        1 => "paper",
        2 => "scissors",
        3 => "rock",
        _ => randomEnemySelection
    };
    Console.WriteLine("Enemy selected number: " + randomNumber + " Enemy based by number selection is: " + randomEnemySelection);

    var humanSelection = Console.ReadLine();
    Console.WriteLine("Human selection is:" + humanSelection);

    // var enemyChanceToBlock = new Random();
    // var enemyBlockChane = enemyChanceToBlock.Next(1, 100);
    //
    // var humanChanceToHit = new Random();
    // var humanSlowHighAttack = humanChanceToHit.Next(40, 60);
    // var humanMediumAttack = humanChanceToHit.Next(50, 80);
    // var humanFastLowAttack = humanChanceToHit.Next(60, 90);
    //
    // var humanChanceToBlock = new Random();
    // var humanBlockChane = humanChanceToBlock.Next(1, 100);
    //
    // var enemyChanceToHit = new Random();
    // var enemySlowHighAttack = enemyChanceToHit.Next(40, 60);
    // var enemyMediumAttack = enemyChanceToHit.Next(50, 80);
    // var enemyFastLowAttack = enemyChanceToHit.Next(60, 90);
    //
    // var enemyAttack = new Random();

    while (userHealth > 0 || enemyHealth > 0)
    {
        // var enemyAttackType = enemyAttack.Next(1, 3);
        // switch (enemyAttackType)
        // {
        //     case 1:
        //         break;
        //     case 2:
        //         break;
        //     case 3:
        //         break;
        // }
        
        switch (humanSelection)
        {
            case "paper":
                switch (randomEnemySelection)
                {
                    case "paper":
                        Console.WriteLine("You and Enemy blocked the attacks");
                        // Console.WriteLine($"Both you and enemy health remains the same: Enemy Health: {enemyHealth} and Your Health: {userHealth}");
                        break;
                    case "scissors":
                        Console.WriteLine("Enemy wins");
                        break;
                    case "rock":
                        Console.WriteLine("Human wins");
                        break;
                }
                break;
            case "scissors":
                switch (randomEnemySelection)
                {
                    case "paper":
                        Console.WriteLine("Human Wins");
                        break;
                    case "scissors":
                        Console.WriteLine("Ties");
                        break;
                    case "rock":
                        Console.WriteLine("Enemy Wins");
                        break;
                }
                break;
            case "rock":
                switch (randomEnemySelection)
                {
                    case "paper":
                        Console.WriteLine("Enemy Wins");
                        break;
                    case "scissors":
                        Console.WriteLine("Human Wins");
                        break;
                    case "rock":
                        Console.WriteLine("Ties");
                        break;
                }
                break;
        }
    }
  



}