using CSharpClassProject;
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

//Random random = new Random();

//int winningNumber = random.Next(1, 11);
//int userGuessNumber = 0;
//int numberOfAttempts = 0;

//while (userGuessNumber != winningNumber)
//{
//    Console.WriteLine("Guess a number between 1 and 10");
//    userGuessNumber = int.Parse(Console.ReadLine());
//    numberOfAttempts++;

//    if (userGuessNumber != winningNumber)
//    {
//        Console.WriteLine($"You guessed {userGuessNumber}. This is incorrect. This is your {numberOfAttempts} attempt");
//    }
//}

//Console.WriteLine($"You guessed the number 8. It took you {numberOfAttempts} attempts.");
//Console.ReadKey();



//Console.WriteLine("Welcome to the Adventure Game!");
//Console.WriteLine("Enter your character's name: ");
//string playersName = Console.ReadLine();

//Console.ReadKey();

//int userNumber = 0;
//int numberCount = 0;
//bool continueLoop = true;

//do
//{
//    Console.WriteLine("Please enter number");
//    int inputNumber = int.Parse(Console.ReadLine());
//    userNumber += inputNumber;
//    numberCount++;
//    Console.WriteLine($"Continue to add more numbers yes/no?");
//    string userResponse = Console.ReadLine().ToLower().Trim();  

//    if (userResponse == "no" || userResponse == "n")
//    {
//        continueLoop = false; 
//    }

//}
//while (continueLoop);

//Console.WriteLine($"The average is {userNumber / numberCount}");
//Console.ReadKey();

//string[] weekdays = ["Mon", "Tue", "Wed", "Thu", "Fri"];


//int[,] matrix = new int[3, 3]
//{
//    {1, 2, 3},
//    {4, 5, 6},
//    {7, 8, 9}
//};

//Console.WriteLine(matrix[1, 1]);

//int[,,] array = new int[2, 2, 2]
//{
//    {
//        {1, 2},
//        {3, 4}
//    },
//    {
//        {5, 6},
//        {7, 8}
//    }
//};


//int[,] arrayField = new int[3, 3]
//{
//    { 1, 2, 3},
//    {4, 5, 6},
//    {7, 8, 9}
//};
//int column = arrayField.GetLength(0);
//int row = arrayField.GetLength(1);

//for (int i = 0; i < column; i++)
//{
//    int sumArry = 0;
//    for (int j = 0; j < row; j++)
//    {
//        sumArry += arrayField[i, j];
//    }
//    Console.WriteLine(sumArry);
//}

//Console.ReadKey();

//using System;

//int[] numberArray = [1, 2, 3, 4, 5, 6];
//foreach(int number in numberArray)
//{
//    Console.WriteLine(number);
//}
//Console.ReadKey();
//Static

//using System.Diagnostics.CodeAnalysis;

//Console.WriteLine("Insert the number of days to simulate");
//int numberOfDays = int.Parse(Console.ReadLine());
//Random random = new Random();

//int[] temperature = new int[numberOfDays];
//string[] daysOfWeek = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
//string[] weatherCondition = { "Sunny", "Raining", "Cloudy", "Thunderstorm", "Snowy"};
//string[] WeatherConditions = new string[numberOfDays];
//double averageTemp = 0;

//for (int i = 0; i < numberOfDays; i++)
//{
//    temperature[i] = random.Next(-10, 40);
//    WeatherConditions[i] = weatherCondition[random.Next(0, weatherCondition.Length)];
//    Console.WriteLine($"Day {daysOfWeek[i]}: {temperature[i]}°C, {WeatherConditions[i]}");
//}

//averageTemp = calculateAverage(temperature);
//Console.WriteLine($"The average temperature over {numberOfDays} days is: {averageTemp}°C");
//Console.WriteLine($"The max tempreture is {temperature.Max()}°C and the minimum tempreture is {temperature.Min()}");
//Console.ReadKey();

//static double calculateAverage(int[] temperature)
//{
//    double sum = 0;
//    foreach (int temp in temperature)
//    {
//        sum += temp;
//    }

//    return  sum / temperature.Length;
//}

//static int findMaxTemperature(int[] temperature)
//{
//    int maxTemp = temperature[0];
//    foreach (int temp in temperature)
//    {
//        if (temp > maxTemp)
//        {
//            maxTemp = temp;
//        }
//    }
//    return maxTemp;
//}

//static int findMinTemperature(int[] temperature)
//{
//    int minTemp = temperature[0];
//    foreach (int temp in temperature)
//    {
//        if (temp < minTemp)
//        {
//            minTemp = temp;
//        }
//    }
//    return minTemp;
//}

//static void PrintAverage(double[] temperatures)
//{
//    // TODO
//    double sum = CalculateAverage(temperatures);
//    Console.WriteLine($"The average temperature is: {sum}");

//}

//Console.ReadKey();

//static double CalculateAverage(double[] temperatures)
//{
//    // TODO
//    double sum = 0;

//    for (int i = 0; i < temperatures.Length; i++)
//    {
//        sum += temperatures[i];
//    }

//    return sum / temperatures.Length;
//}

//When a function is inside a class it is called a method


//Car car = new Car("Audi A3");
//Car anotherCar = new Car("BMW X5");
//Console.WriteLine(car);
//Console.ReadKey();


Console.WriteLine("Welcome to the Quiz Game!");
Question[] questions = new Question[]
{
    new Question("What is the capital of France?", 
    new string[] { "Berlin", "Madrid", "Paris", "Rome" }, 
    2),
    new Question("What is 2 + 2?", 
    new string[] { "3", "4", "5", "6" },
    1),
    new Question("What is the largest planet in our solar system?", 
    new string[] { "Earth", "Mars", "Jupiter", "Saturn" },
    2)
};

Quiz myQuiz = new Quiz(questions);
myQuiz.DisplayQuestion(questions[0]);
Console.ReadLine();