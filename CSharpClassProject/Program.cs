// See https://aka.ms/new-console-template for more information
//double myNumber = 0;
//double mySecondNumber = 0;
//double myTotal = 0;

//Console.WriteLine("Enter First Number");

//// Declare Variable
////Naming convention: camelCase for variables, PascalCase for classes and method

//myNumber = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter Second Number");

//mySecondNumber = double.Parse(Console.ReadLine());

//myTotal = Math.Round(myNumber + mySecondNumber, 2);


//Console.WriteLine($"The total is: {myTotal}");
//Console.ReadKey();

//Relational Operators  >= == != >
/*
Multiline comment out
 */


//int age = 0;
//int winningNumber = 9;

//Console.WriteLine("Enter your age");

//age = int.Parse(Console.ReadLine());

//if (age >= 18)
//{
//    Console.WriteLine("Enter number");
//    int userNumber = int.Parse(Console.ReadLine());

//    if (userNumber == winningNumber)
//    {
//        Console.WriteLine("YOU WON!");
//        Console.ReadKey();
//    }
//    else
//    {
//        Console.WriteLine("YOU Lost!");
//        Console.ReadKey();
//    }
//}
//else
//{
//    Console.WriteLine("You are a minor");
//}

int userAge = 0;
bool isWithParents = true;

Console.WriteLine("Enter your age");
userAge = int.Parse(Console.ReadLine());

if (userAge >= 18)
{
    Console.WriteLine("You can enter since you are over 18..");
    Console.ReadKey();
} else if (userAge < 18 && isWithParents)
{
    Console.WriteLine("You can enter with your parents");
    Console.ReadKey();
}
else
{
    Console.WriteLine("You cannot enter the event.");
    Console.ReadKey();
}


//int month = 5;
//string monthName;
//if (month == 1)
//    monthName = "Jan";
//else if (month == 2)
//    monthName = "Feb";
//else if (month == 3)
//    monthName = "Mar";
//else if (month == 4)
//    monthName = "Apr";
//else if (month == 5)
//    monthName = "May";
//else if (month == 6)
//    monthName = "Jun";
//else if (month == 7)
//    monthName = "Jul";
//else if (month == 8)
//    monthName = "Aug";
//else if (month == 9)
//    monthName = "Sep";
//else if (month == 10)
//    monthName = "Oct";
//else if (month == 11)
//    monthName = "Nov";
//else if (month == 12)
//    monthName = "Dec";
//else
//    monthName = "Invalid Month";
