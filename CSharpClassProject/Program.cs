// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter First Number");

// Declare Variable
//Naming convention: camelCase for variables, PascalCase for classes and methods    

string? userFirstInput = Console.ReadLine();

Console.WriteLine("Enter Second Number");

string? userSecondInput = Console.ReadLine();

int? total = int.Parse(userFirstInput) + int.Parse(userSecondInput);

Console.WriteLine("The total is: " + total);
Console.ReadKey();