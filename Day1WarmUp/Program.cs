// Uncomment to run selected task

// Task1();
// Task2();
// Task3();
// Task4();
// Task5();


void Task1()
{
    string test1 ="   /\\"+
                  "\n  /  \\"+
                  "\n /    \\"+
                  "\n/______\\";
    Console.WriteLine(test1);
}

void Task2()
{
    const string test2 = "     *****" +
                         "\n   **     **" +
                         "\n **         **" +
                         "\n**   Hello   **" +
                         "\n**   from    **" +
                         "\n **         **" +
                         "\n   **     **" +
                         "\n     *****";
    Console.WriteLine(test2);
}

void Task3()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("   /\\");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("  /  \\");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(" /    \\");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("/______\\");
}

void Task4()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("   / \\     / \\");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("  /   \\   /   \\");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("  \\    \\ /    /");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("   \\         /");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("    \\       /");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("     \\     /");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("      \\   /");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("       \\ /");
}

void Task5()
{
    Console.ForegroundColor = ConsoleColor.White;
    const string vcard1 = "========== Visit Card =============";
    const string name = "Name Surname";
    const int age = 28;
    const string responsibilities = "Software developer";
    const string email = "johndoe@example.com";
    const string phone = "+1 123-456-7890 ";
    const string vcard2 = "===================================";
    
    Console.WriteLine(vcard1+ "\n"+"Name: "+ name+ 
                      "\n"+"Age: " + age + 
                      "\n"+"Responsibilities: " + responsibilities + 
                      "\n"+"Email: " + email + 
                      "\n"+"Phone: " + phone + 
                      "\n"+ vcard2);
}