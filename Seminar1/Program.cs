// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на смо себя) 
//Например, 4-> 16, -3->9, -7 -> 49


Console.Write("Введите целое число -> ");
int num = int.Parse(Console.ReadLine());
int numResult = num * num;
Console.Write("Квадрат числа равен -> ");
Console.WriteLine(numResult);