// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//Задание 1.1
Console.WriteLine("Задание 1.1");
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}
//Задание 1.2
Console.WriteLine("Задание 1.2");
for (int i = 2; i <= 50; i+=2)
{
    Console.WriteLine(i);
}
//Задание 2
Console.WriteLine("Задание 2");
int c1 = 0;
int c2 = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        c1 += i;
    }
    if (i % 7 == 0)
    {
        c2++;
    }
}
Console.WriteLine(c1);
Console.WriteLine(c2);
//Задание 3
Console.WriteLine("Задание 3");
int number = Convert.ToInt32(Console.ReadLine());
int t1 = 0;
int t2 = 0;
while (number != 0)
{
    if (number > 0)
    {
        t1++;
    }
    else
    {
        t2++;
    }
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Положительных {t1}");
Console.WriteLine($"Отрицательных {t2}");

//Задание 4
Console.WriteLine("Задание 4");
bool ctry = false;
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Введите пароль:");
    string password = Console.ReadLine();
    if (password != "qwerty")
    {
        Console.WriteLine("Пароль не верный");
    }
    else
    {
        Console.WriteLine("Правильный пароль!!!");
        ctry = true;
        break;
    }
}
if (ctry == true)
{
    Console.WriteLine("Пароль введен верно, вход в систему...");
}
else
{
    Console.WriteLine("Попытки закончились, система заблокирована.");
}
//Задание 5
Console.WriteLine("Задание 5");
int number1 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number1} x {i} = {i * number1}");
}
//Задание 6
Console.WriteLine("Задание 6");
for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0) continue;
    Console.WriteLine($"{i}");
}