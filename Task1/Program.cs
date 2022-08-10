// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество чисел");
int x = Convert.ToInt32(Console.ReadLine());
int n = 0;

int y = 0;
for (int i = 0; i < x; i++)
{
    Console.WriteLine("Введите число");
    y = Convert.ToInt32(Console.ReadLine());
    if (y > 0)
        n++;
}
Console.WriteLine(n);
