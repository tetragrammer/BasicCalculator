// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter first number to substract: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number to substract: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int difference = num1 - num2;

Console.WriteLine($"The difference between {num1} and {num2} = {difference}");
