Task11();
Task12();
Task13();
Task21();
Task22();
Task23();
Task31();
Task32();
Task33();


#region Task1.1

void Task11()
{
    Console.WriteLine("Enter week of the day");
     var dayOfTheWeek = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    switch (dayOfTheWeek)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("There is no such day of the week");
            break;
    }
}

#endregion

#region Task1.2

void Task12()
{
    Console.WriteLine("Enter age");
    var age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    switch (age)
    {
        case <= 18 and >= 7:
            Console.WriteLine("Middle School");
            break;
        case <= 25:
            Console.WriteLine("Student");
            break;
        case <= 65:
            Console.WriteLine("Employee");
            break;
        case > 65:
            Console.WriteLine("Retired");
            break;
    }
}

#endregion

#region Task1.3

void Task13()
{
    Console.WriteLine("Enter month number");
    var monthNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    switch (monthNumber)
    {
        case 1:
            Console.WriteLine("January");
            break;
        case 2:
            Console.WriteLine("February");
            break;
        case 3:
            Console.WriteLine("March");
            break;
        case 4:
            Console.WriteLine("April");
            break;
        case 5:
            Console.WriteLine("May");
            break;
        case 6:
            Console.WriteLine("June");
            break;
        case 7:
            Console.WriteLine("July");
            break;
        case 8:
            Console.WriteLine("August");
            break;
        case 9:
            Console.WriteLine("September");
            break;
        case 10:
            Console.WriteLine("October");
            break;
        case 11:
            Console.WriteLine("November");
            break;
        case 12:
            Console.WriteLine("December");
            break;
        default:
            Console.WriteLine("Wrong number of month");
            break;
    }
}

#endregion

#region Task2.1

void Task21()
{
    Console.WriteLine("Enter shape");
    var shape = Console.ReadLine() ?? throw new InvalidOperationException();
    switch (shape.ToLowerInvariant())
    {
        case "square":
            Console.WriteLine("Square area calculation:");
            Console.WriteLine("Enter square distance");
            var squareA = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Square area is { squareA * squareA }");
            break;
        case "triangle":
            Console.WriteLine("Triangle area calculation(Taking in mind that triangle has 90degree):");
            Console.WriteLine("Enter 1st triangle distance 'a'");
            var triangleA = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Enter 2nd triangle distance 'b'");
            var triangleB = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Enter 3d triangle distance 'b'");
            var triangleC = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            if (triangleA > triangleB && triangleA > triangleC)
            {
                Console.WriteLine($"Triangle area is { Math.Sqrt(triangleB * triangleB + triangleC * triangleC) }");
            }
            if (triangleB > triangleA && triangleB > triangleC)
            {
                Console.WriteLine($"Triangle area is { Math.Sqrt(triangleC * triangleC + triangleA * triangleA) }");
            }
            if (triangleC > triangleA && triangleC > triangleB)
            {
                Console.WriteLine($"Triangle area is { Math.Sqrt(triangleA * triangleA + triangleB * triangleB) }");
            }
            break;
        case "circle":
            Console.WriteLine("Circle area calculation:");
            Console.WriteLine("Enter circle radius");
            var circleRadius = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Circle area is:{ Math.PI * circleRadius * circleRadius }");
            break;
        case "rectangle":
            Console.WriteLine("Rectangle area calculation:");
            Console.WriteLine("Enter 1st rectangle distance 'a'");
            var rectangleA = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Enter 2nd rectangle distance 'b'");
            var rectangleB = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Square area is { rectangleA * rectangleB }");
            break;
        default:
            Console.WriteLine("Shape is not registered in this application");
            break;
    }
}

#endregion

#region Task2.2

void Task22()
{
    Console.WriteLine("Enter basic element");
    var element = Console.ReadLine() ?? throw new InvalidOperationException();
    switch (element.ToLowerInvariant())
    {
        case "fire":
            Console.WriteLine("Fuel, Oxygen and Heat are the 3 main characteristics of fires");
            break;
        case "water":
            Console.WriteLine("High polarity, high specific heat, high heat of vaporization, low density as a solid, and attraction to other polar molecules");
            break;
        case "air":
            Console.WriteLine("As a gas, air can be compressed");
            break;
        case "earth":
            Console.WriteLine("Solid terrestrial surface of Earth not submerged by the ocean or another body of water");
            break;
        default:
            Console.WriteLine("No basic element found");
            break;
    }
}

#endregion

#region Task2.3

void Task23()
{
    Console.WriteLine("Enter university major");
    var universityMajor = Console.ReadLine() ?? throw new InvalidOperationException();
    switch (universityMajor.ToLowerInvariant())
    {
        case "math":
            Console.WriteLine("Enter math school grade:");
            var mathSchoolGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Enter math exam grade:");
            var mathExamGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var totalMathGrade = (mathSchoolGrade * mathExamGrade) / 2;
            totalMathGrade = Convert.ToInt32(totalMathGrade);
            if (totalMathGrade is > 0 and <= 10) 
            {
                switch (totalMathGrade)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("You have very low chance to math admission");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("You have very average chance to math admission");
                        break;
                    case 9:
                    case 10:
                        Console.WriteLine("You have very high chance to math admission");
                        break;
                }
            }
            else
            {
                Console.WriteLine("One of the grades entered is incorrect");
            }
            break;
        case "computer":
            Console.WriteLine("Enter computer school grade:");
            var computerSchoolGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Enter computer exam grade:");
            var computerExamGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var totalComputerGrade = (computerSchoolGrade * computerExamGrade) / 2;
            if (totalComputerGrade is > 0 and <= 10)
            {
                switch (totalComputerGrade)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("You have very low chance to computer admission");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("You have very average chance to computer admission");
                        break;
                    case 9:
                    case 10:
                        Console.WriteLine("You have very high chance to computer admission");
                        break;
                }
            }
            else
            {
                Console.WriteLine("One of the grades entered is incorrect");
            }
            break;
        case "science":
            Console.WriteLine("Enter science school grade:");
            var scienceSchoolGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Enter science exam grade:");
            var scienceExamGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var totalScienceGrade = (scienceSchoolGrade * scienceExamGrade) / 2;
            if (totalScienceGrade is > 0 and <= 10)
            {
                switch (totalScienceGrade)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("You have very low chance to science admission");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("You have very average chance to science admission");
                        break;
                    case 9:
                    case 10:
                        Console.WriteLine("You have very high chance to science admission");
                        break;
                }
            }
            else
            {
                Console.WriteLine("One of the grades entered is incorrect");
            }
            break;
        case "biology":
            Console.WriteLine("Enter biology school grade:");
            var biologySchoolGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Enter biology exam grade:");
            var biologyExamGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var totalBiologyGrade = (biologySchoolGrade * biologyExamGrade) / 2;
            if (totalBiologyGrade is > 0 and <= 10)
            {
                switch (totalBiologyGrade)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("You have very low chance to biology admission");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("You have very average chance to biology admission");
                        break;
                    case 9:
                    case 10:
                        Console.WriteLine("You have very high chance to biology admission");
                        break;
                }
            }
            else
            {
                Console.WriteLine("One of the grades entered is incorrect");
            }
            break;
        case "chemistry":
            Console.WriteLine("Enter chemistry school grade:");
            var chemistrySchoolGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Enter chemistry exam grade:");
            var chemistryExamGrade = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var totalChemistryGrade = (chemistrySchoolGrade * chemistryExamGrade) / 2;
            if (totalChemistryGrade is > 0 and <= 10)
            {
                switch (totalChemistryGrade)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("You have very low chance to chemistry admission");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("You have very average chance to chemistry admission");
                        break;
                    case 9:
                    case 10:
                        Console.WriteLine("You have very high chance to chemistry admission");
                        break;
                }
            }
            else
            {
                Console.WriteLine("One of the grades entered is incorrect");
            }
            break;
        default:
            Console.WriteLine("No university major found");
            break;
    }
}

#endregion

#region Task3.1

void Task31()
{
    Console.WriteLine("Enter month element");
    var monthNumber = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        switch (monthNumber)
        {
            case 1:
            case 2:
                Console.WriteLine("Summer season");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Autumn season");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Winter season");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Spring season");
                break;
            case 12:
                Console.WriteLine("Summer season");
                break;
            default:
                Console.WriteLine("Such month does not exist");
                break;
        }
}

#endregion

#region Task3.2

void Task32()
{
    Console.WriteLine("Select mathematical operation: (1-addition,2-subtraction,3-multiplication,4-division,5-squaring,6-root pulling)");
    var mathOperation = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    switch (mathOperation)
    {
        case 1:
            Console.WriteLine("Add first number for addition:");
            var add1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Add second number for addition:");
            var add2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Sum of two is:{add1 + add2}");
            break;
        case 2:
            Console.WriteLine("Add first number for subtraction:");
            var sub1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Add second number for subtraction:");
            var sub2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Sum of two is:{sub1 - sub2}");
            break;
        case 3:
            Console.WriteLine("Add first number for multiplication:");
            var multi1 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Add second number for multiplication:");
            var multi2 = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Sum of two is:{multi1 * multi2}");
            break;
        case 4:
            Console.WriteLine("Add first number for division:");
            var div1 = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("Add second number for multiplication:");
            var div2 = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Sum of two is:{div1 / div2}");
            break;
        case 5:
            Console.WriteLine("Enter number for squaring:");
            var square = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Sum of two is:{square*square}");
            break;
        case 6:
            Console.WriteLine("Enter number for root pulling:");
            var sqrt = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"Sum of two is:{Math.Sqrt(sqrt)}");
            break;
        default:
            Console.WriteLine("Such Mathematical operation does not exist");
            break;
    }
}

#endregion

#region Task3.3

void Task33()
{
    Console.WriteLine("Select currency for conversion: (1-USD,2-EUR,3-GBP,4-JPY)");
    var selectedCurrency = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    switch (selectedCurrency)
    {
        case 1:
            Console.WriteLine("Converting USD to EUR,GBP,JPY:");
            Console.WriteLine("Enter amount to convert:");
            var usd = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"USD to EUR: {usd*0.63:0.002} Euros" +
                              $"\nto GBP: {usd*0.81:0.00} Pounds" +
                              $"\nto JPY: {usd*150.36:0.00} Yens");
            break;
        case 2:
            Console.WriteLine("Converting EUR to USD,GBP,JPY:");
            Console.WriteLine("Enter amount to convert:");
            var eur = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"EUR to USD: {eur*1.07:0.00} Euros" +
                              $"\nto GBP: {eur*0.87:0.00} Pounds" +
                              $"\nto JPY: {eur*160.86:0.00} Yens");
            break;
        case 3:
            Console.WriteLine("Converting GBP to USD,EUR,JPY:");
            Console.WriteLine("Enter amount to convert:");
            var gbp = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"GBP to USD: {gbp*1.23:0.00} Dollars" +
                              $"\nto EUR: {gbp*1.15:0.00} Euros" +
                              $"\nto JPY: {gbp*184.90:0.00} Yens");
            break;
        case 4:
            Console.WriteLine("Converting JPY to USD,EUR,GBP:");
            Console.WriteLine("Enter amount to convert:");
            var jpy = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine($"JPY to USD: {jpy*0.0067:0.00} Dollars" +
                              $"\nto EUR: {jpy*0.0062:0.00} Euros" +
                              $"\nto GBP: {jpy*0.0054:0.00} Pounds");
            break;
        default:
            Console.WriteLine("Such operation does not exist");
            break;
    }
}

#endregion