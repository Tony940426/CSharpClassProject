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

//int userAge = 0;
//bool isWithParents = true;

//Console.WriteLine("Enter your age");
//userAge = int.Parse(Console.ReadLine());

//if (userAge >= 18)
//{
//    Console.WriteLine("You can enter since you are over 18..");
//    Console.ReadKey();
//} else if (userAge < 18 && isWithParents)
//{
//    Console.WriteLine("You can enter with your parents");
//    Console.ReadKey();
//}
//else
//{
//    Console.WriteLine("You cannot enter the event.");
//    Console.ReadKey();
//}


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

//int userScore= 0;
//string question1 = "What is the capital of France?";
//string question2 = "What is 2 + 2?";
//string question3 = "What is the largest planet in our solar system?";
//string userAnswer1 = "";
//string userAnswer2 = "";    
//string userAnswer3 = "";

//Console.WriteLine(question1);
//userAnswer1 = Console.ReadLine();  

//if(userAnswer1.ToUpper().Trim() == "PARIS")
//{
//    userScore ++;
//    Console.WriteLine("Correct! Your score is now: " + userScore);
//} else
//{
//    Console.WriteLine("Incorrect! The correct answer is Paris. GAME OVER");
//    Console.ReadKey();
//}

//Console.WriteLine(question2);
//userAnswer2 = Console.ReadLine();
//if (userAnswer2.ToUpper().Trim() == "4")
//{
//    userScore++;
//    Console.WriteLine("Correct! Your score is now: " + userScore);
//}
//else
//{
//    Console.WriteLine("Incorrect! The correct answer is 4. GAME OVER");
//    Console.ReadKey();
//}

//Console.WriteLine(question3);
//userAnswer3 = Console.ReadLine();
//if (userAnswer3.ToUpper().Trim() == "JUPITER")
//{
//    userScore++;
//    Console.WriteLine("Correct! Your final score is: " + userScore);
//    Console.ReadKey();

//}
//else
//{
//    Console.WriteLine($"Incorrect! The correct answer is Jupiter. Final Score {userScore}. GAME OVER");
//    Console.ReadKey();
//}

//int num1 = 0;

//using System;

//Random random = new Random();
//int randomNumber = random.Next(1, 11); // Generates a number between 1 and 10

//Console.WriteLine("Guess the number");

//int userGuess = 0;  

//if (int.TryParse(Console.ReadLine(), out userGuess))
//{
//    Console.WriteLine($"Valid number entered. The number was {randomNumber}, you guess {userGuess}");
//    Console.ReadKey();
//} else
//{
//    Console.WriteLine($"Invalid number entered The number was {randomNumber}, you guess {userGuess}");
//    Console.ReadKey();
//}

//using System.Diagnostics;
//using System.Runtime.CompilerServices;

//double userFirstNumber = 0;
//double userSecondNumber = 0;
//double finalSum = 0;
//string arithmeticOperation = "";

//Console.WriteLine("Enter the first number:");
//userFirstNumber = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter the second number:");
//userSecondNumber = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Choose an operation: +, -, *, /");
//arithmeticOperation = Console.ReadLine().Trim();

//switch (arithmeticOperation)
//{
//    case "+":
//        finalSum = userFirstNumber + userSecondNumber;
//        Console.WriteLine($"Result: {finalSum}");
//        break;
//    case "-":
//        finalSum = userFirstNumber - userSecondNumber;
//        Console.WriteLine($"Result: {finalSum}");
//        break;
//    case "*":
//        finalSum = userFirstNumber * userSecondNumber;
//        Console.WriteLine($"Result: {finalSum}");
//        break;
//    case "/":
//        if (userFirstNumber == 0 || userSecondNumber == 0)
//        {
//            Console.WriteLine("Division by zero is not allowed.");
//            break;
//        }
//        finalSum = userFirstNumber / userSecondNumber;
//        Console.WriteLine($"Result: {finalSum}");
//        break;
//    default:
//        Console.WriteLine("Invalid operation. Please choose +, -, *, or /");
//        break;

//string myRocket = "|";
//string rocketLanding = "";

//for (int i = 10; i >= 0; i--)
//{
//    Console.Clear();
//    Console.WriteLine($"{rocketLanding}{myRocket}");
//    Thread.Sleep(1000);
//    rocketLanding += "\n";
//}
//Console.WriteLine("The Rocket Has Landed");  
//Console.ReadKey();

//int count = 0;

//while (count <= 10)
//{
//    Console.WriteLine($"Count is: {count}");
//    count++;
//};

//Console.ReadKey();

Random random = new Random();

int winningNumber = random.Next(1, 11);
int userGuessNumber = 0;
int numberOfAttempts = 0;

while (userGuessNumber != winningNumber)
{
    Console.WriteLine("Guess a number between 1 and 10");
    userGuessNumber = int.Parse(Console.ReadLine());
    numberOfAttempts++;

    if (userGuessNumber != winningNumber)
    {
        Console.WriteLine($"You guessed {userGuessNumber}. This is incorrect. This is your {numberOfAttempts} attempt");
    }
}

Console.WriteLine($"You guessed the number 8. It took you {numberOfAttempts} attempts.");
Console.ReadKey();
