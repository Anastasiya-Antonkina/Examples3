Console.WriteLine ("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberMax = 0;
if (numberA > numberB) {
    numberMax = numberA;
}
else {
    numberMax = numberB;
}
Console.Write ("Максимальное число ");
Console.WriteLine (numberMax);