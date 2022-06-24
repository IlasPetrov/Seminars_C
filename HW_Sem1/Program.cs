/*
// Задача №2

Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numB > max) max = numB;

Console.WriteLine("MAX = " + max);

*/
/*
// Задача №4


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;


Console.WriteLine("" + max);

*/
/*
//Задача №6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int temp = num % 2;

if(temp == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}

*/

int Start = 1;
int count = 0;
Console.WriteLine("Пороговое значение: ");
int N = Convert.ToInt32(Console.ReadLine());

while(Start <= N)
{
    if(Start % 2 == 0)
    {
        count++;
    }
    else
    {
        Start++;
    }
}

Console.WriteLine("Кол-во чётных чисел: " + count);



