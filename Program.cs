//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли
// число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int rez = num % 2;
if (rez == 0)
{
    Console.WriteLine("Число четное ");
}
else
{
    Console.WriteLine("Число нечетное ");
}