/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine ("Введите первое число");
string numA = Console.ReadLine();
Console.WriteLine ("Введите второе число");
string numB = Console.ReadLine();
int numberA = Convert.ToInt32 (numA);
int numberB = Convert.ToInt32 (numB);
if (numberA > numberB) 
{
   Console.Write ($"Максимальное число {numberA}");
}
else if (numberA < numberB) 
{
   Console.Write ($"Максимальное число {numberB}");
}
else
{
   Console.Write ("Числа равны");
}
