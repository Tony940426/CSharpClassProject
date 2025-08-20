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


int age = 0;
int winningNumber = 9;

Console.WriteLine("Enter your age");

age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Enter number");
    int userNumber = int.Parse(Console.ReadLine());

    if (userNumber == winningNumber)
    {
        Console.WriteLine("YOU WON!");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("YOU Lost!");
        Console.ReadKey();
    }
}
else
{
    Console.WriteLine("You are a minor");
}