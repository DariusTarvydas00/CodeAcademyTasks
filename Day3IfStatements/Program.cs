// Uncomment to run selected task

// Task11();
// Task12();
// Task21();
// Task22();
// Task31();
// Task32();
// Task4();
// Task5();
// Task6();
// Task71();
// Task72();
// Task81();
// Task82();
// Task9();
// Task10();
// Task111();

void Task11()
{
    Console.WriteLine("Please enter a number it will check if it is equal, greater or less then 100:");
    var enteredNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    if (enteredNumber >= 0)
    {
        if (enteredNumber > 100)
            Console.WriteLine("The number is greater then 100");
        else if (enteredNumber == 100)
            Console.WriteLine("The number is equal to 100");
        else
            Console.WriteLine("The number is less then 100");
    }
}
void Task12()
{
    Console.WriteLine("Please enter day number it will print day in text:");
    int enteredDayNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        if (enteredDayNumber >= 1 | enteredDayNumber <= 7)
        {
            if (enteredDayNumber == 1)
                Console.WriteLine("Monday");
            else if (enteredDayNumber == 2)
                Console.WriteLine("Tuesday");
            else if (enteredDayNumber == 3)
                Console.WriteLine("Wednesday");
            else if (enteredDayNumber == 4)
                Console.WriteLine("Thursday");
            else if (enteredDayNumber == 5)
                Console.WriteLine("Friday");
            else if (enteredDayNumber == 6)
                Console.WriteLine("Saturday");
            else if (enteredDayNumber == 7)
                Console.WriteLine("Sunday");
            else
                Console.WriteLine("Wrong day number");
        }
}
void Task21()
{
    Console.WriteLine("Please enter number to check if divisible by 5:");
    int enteredNumberDivision = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    if (enteredNumberDivision % 5 == 0) 
        Console.WriteLine("Number is divisible by 5");
    else
        Console.WriteLine("Number does not meet any conditions");
}
void Task22()
{
    Console.WriteLine("Please enter a temperature:");
    int enteredNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    if (enteredNumber < 0)
        Console.WriteLine("Cold");
    if (enteredNumber <= 20 && enteredNumber >= 0)
        Console.WriteLine("Cool");
    if (enteredNumber > 20)
        Console.WriteLine("Hot");
}
void Task31()
{
    Console.WriteLine("Please enter hour when you have woken up (24h format. ex: 18):");
    var enteredNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        if (enteredNumber >= 6 & enteredNumber <= 12)
            Console.WriteLine("Good day!");
        else if (enteredNumber > 12 & enteredNumber <= 18)
            Console.WriteLine("Good afternoon!");
        else if (enteredNumber > 18 & enteredNumber <= 24)
            Console.WriteLine("Good evening!");
}
void Task32()
{
    Console.WriteLine("Please create a new password:");
    string newPassword = "";
    newPassword = Console.ReadLine() ?? throw new InvalidOperationException();
    Console.WriteLine("Please enter your password:");
    string tryPassword = "";
    tryPassword = Console.ReadLine() ?? throw new InvalidOperationException();
    if (newPassword == tryPassword)
        Console.WriteLine("You have successfully logged in");
    else if (tryPassword == "Mellon")
        Console.WriteLine("You have successfully logged in 2");
    else if (tryPassword == "01101001 01101110")
        Console.WriteLine("Hacked..");
    else
        Console.WriteLine("Password is incorrect, please try again..");
}
void Task4()
{
    Console.WriteLine("Please enter your age:");
    int age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    if (age < 18)
        Console.WriteLine("You are a minor");
    else if (age > 65)
        Console.WriteLine("You are an adult");
    else
        Console.WriteLine("You are eligible for the Senior Citizen promotion");
}
void Task5()
{
    Console.WriteLine("Please enter number to check if it is a leap of the year:");
    int enteredNumberDivision = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    if ((enteredNumberDivision % 4 == 0 && enteredNumberDivision % 100 != 0) || enteredNumberDivision % 400 == 0) 
        Console.WriteLine("This is a leap year");
    else
        Console.WriteLine("This is not a leap year");
}
void Task6()
{
    Console.WriteLine("enter to check number for division:");
    int number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    if (number % 3 == 0 && number % 5 == 0)
        Console.WriteLine("BazingaPop");
    else if (number % 3 == 0)
        Console.WriteLine("Bazinga");
    else if (number % 5 == 0)
        Console.WriteLine("Pop");
    else
        Console.WriteLine(number);
}
void Task71()
{
    Console.WriteLine("enter first number:");
    int number1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("enter second number:");
    int number2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("enter two numbers for comparison: (-999 to exit application):");
    if (number1 >= 0 && number2 >= 0)
        Console.WriteLine("Both numbers are positive");
    else if (number1 <= 0 && number2 <= 0)
        Console.WriteLine("Neither number is positive");
    else
        Console.WriteLine("Only one number is positive");
}
void Task72()
{
    Console.WriteLine("enter three numbers for comparison: Start with first number:");
    int number1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("enter second number:");
    int number2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("enter third number:");
    int number3 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    if (number1 == number2 && number1 == number3)
        Console.WriteLine("All numbers are equal");
    else if (number1 == number2 || number2 == number3 || number1 == number3)
        Console.WriteLine("Two numbers are equal");
    else
        Console.WriteLine("None of the numbers are equal");
}
void Task81()
{
    Console.WriteLine("enter three numbers for checking if at least two are positive:");
    Console.WriteLine("enter first number:");
    int number1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("enter second number:");
    int number2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("enter third number:");
    int number3 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        
    if (number1 >= 0 && number2 >= 0 && number3 >= 0)
        Console.WriteLine("Sum of all three positive numbers are: " + number1+number2+number3);
    else if (number1 >= 0 && number2 >= 0)
        Console.WriteLine("Sum of first and second positive numbers are: " + number1+number2);
    else if (number2 >= 0 && number3 >= 0)
        Console.WriteLine("Sum of second and third positive numbers are: " + number2+number3);
    else if (number1 >= 0 && number3 >= 0)
        Console.WriteLine("Sum of first and third positive numbers are: " + number1+number3);
    else
        Console.WriteLine("Could not calculate sum");
}
void Task82()
{
    Console.WriteLine("enter month it will check for type of weather:");
    string month = Console.ReadLine()?.ToLowerInvariant() ?? throw new InvalidOperationException();
    Console.WriteLine("enter month:");
    if (month == "january" || month == "february" || month == "march") 
        Console.WriteLine("Cold period");
    else if (month == "june" || month == "july" || month == "august")
        Console.WriteLine("Hot period");
    else
        Console.WriteLine("Medium period month");
}
void Task9()
{
    Console.WriteLine("enter three numbers to check if triangle is possible::");
    Console.WriteLine("enter first number:");
    int number1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("enter second number:");
    int number2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("enter third number:");
    int number3 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    
    if (number1 > number2 && number2 > number3 || number2 > number3 && number2 > number1 || number3 > number1 && number3 > number2) 
        Console.WriteLine("Triangle is possible");
    else
        Console.WriteLine("Triangle not possible");
}
void Task10()
{
    double applePrice = 10;
    double penPrice = 20;
    double bootPrice = 500;
    double appleSelected = 0;
    double penSelected = 0;
    double bootSelected = 0;
    
    Console.WriteLine("Shopping application:");
    Console.WriteLine("In our store we have those items to choose from: Apple, Pen and Boot");
    
    Console.WriteLine("How many apples you would like to buy ? (enter number)");
    appleSelected = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("How many pens you would like to buy ? (enter number)");
    appleSelected = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.WriteLine("How many boots you would like to buy ? (enter number)");
    bootSelected = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

    #region Main option
    if (appleSelected >= 2)
    {
        applePrice = applePrice * 0.9 * appleSelected;
        Console.WriteLine($"Apple got discount:{applePrice}");
    }
    if (penSelected >= 2)
    {
        penPrice = penPrice * 0.9 * penSelected;
        Console.WriteLine($"Pen got discount:{penPrice}");
    }
    if (bootSelected >= 2)
    {
        bootPrice = bootPrice * 0.9 * bootSelected;
        Console.WriteLine($"Boot got discount:{bootPrice}");
    }
    #endregion

    #region Additional option
    // if (appleSelected >= 2 || penSelected >= 2 || bootSelected >= 2)
    // {
    //     applePrice = applePrice * 0.9 * appleSelected;
    //     penPrice = penPrice * 0.9 * penSelected;
    //     bootPrice = bootPrice * 0.9 * bootSelected;
    // }
    #endregion
    Console.WriteLine($"Total basket price:{applePrice+bootPrice+penPrice}");
}
void Task111()
{
    string logo = $"This is Maze Logo" +
                  $"Find minotaur to fight";
    Console.WriteLine(logo);
    Console.WriteLine("Press any kay to start the game:");
    Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Press 1 to go to minotaur or press 2 to not go to minotaur");
    int selection = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    Console.Clear();
    if (selection == 1)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Congratulations you met minotaur which beaten you. End of The game!");
    } 
    else if (selection == 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Minotaur escaped. You won!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.WriteLine("This is very short game.");
    }
}