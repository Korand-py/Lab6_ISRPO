// Задание 1.1
using System.Threading.Channels;

Console.WriteLine("#1 ---------------------");
for (int i = 10; i >= 1; i -= 1)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------------------");

for (int i = 2; i <= 50; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("---------------------");

int sum = 0;
for (int i = 1; i <= 10; i++)
{
    sum += 1;
}
Console.WriteLine($"Сумма: {sum}");

int c = 0;
for (int i = 1; i <= 20; i++)
{
    if (i % 5 == 0)
    {
        c ++;
    }
}
Console.WriteLine($"Количество: {c}");
Console.WriteLine("#2 ---------------------");

int sum_3 = 0;
int count_7 = 0;

for (int i = 1; i <= 100; i ++)
{
    if (i % 3 == 0)
    {
        sum_3 += i;
    }
    if (i % 7 == 0)
    {
        count_7 += 1;
    }
}
Console.WriteLine($"Сумма кратных 3 равна: {sum_3}");
Console.WriteLine($"Количество кратных 7 равно: {count_7}");

//Console.WriteLine("#Пример ---------------------");

// int number = Convert.ToInt32(Console.ReadLine());
// int total = 0;

// while (number != 0)
// {
//     total += number;
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Сумма: {total}");

Console.WriteLine("#3 ---------------------");

int num_plus = 0;
int num_minus = 0;

int number = Convert.ToInt32(Console.ReadLine());

while (number != 0)
{
    if (number < 0)
    {
        num_minus += 1;
    } else
    {
        num_plus += 1;
    }
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"(-) {num_minus}");
Console.WriteLine($"(+) {num_plus}");

Console.WriteLine("#4 ---------------------");

String password;
int p = 3;

do
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine();
    p -= 1;
    if (p == 0)
    {
        Console.WriteLine("Доступ заблокирован!");
        break;
    }
    if (password == "qwerty")
    {
        Console.WriteLine("Доступ разрешён!");
        break;
    }
}
while (p != 0);

Console.WriteLine("#5 ---------------------");

int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}
Console.WriteLine("#6 ---------------------");

for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    if (i % 10 == 0 & i > 20)
    {
        break;
    }
    Console.WriteLine(i);
}
Console.WriteLine("#Final Game ---------------------");

int secret = 42;
int count_p = 5;
Console.Write("Угадай число: ");
int user_input = Convert.ToInt32(Console.ReadLine());
do
{
    count_p -= 1;
    if (user_input > secret)
    {
        Console.WriteLine("Меньше");
    } if (user_input < secret)
    {
        Console.WriteLine("Больше");
    } if (user_input == secret)
    {
        Console.WriteLine($"Победа! Попыток осталось: {count_p}");
        break;
    } if (count_p == 0)
    {
        Console.WriteLine($"Вы проиграли, число было {secret}");
        break;
    };
    user_input = Convert.ToInt32(Console.ReadLine());
} while (count_p != 0);