// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Welcome to Broadway Calculaltor");


Console.WriteLine("Please provide the first iput");
int firstInput = int.Parse(Console.ReadLine());


Console.WriteLine("Please provide the second input");
int secondInput = int.Parse(Console.ReadLine());

int sum = firstInput + secondInput;
Console.WriteLine(($"The result is : {sum}"));

