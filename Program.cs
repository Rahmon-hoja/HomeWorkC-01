// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7;
// a = 2; b = 10 -> max = 10;
// a = -9; b = -3 -> max = -3;

/*
int a, b;
 
Console.WriteLine("Введите два числа: ");

a = Convert.ToInt32(Console.ReadLine());

b = Convert.ToInt32(Console.ReadLine());
 
if (a > b)
 
    {
 
        Console.WriteLine("{0} наибольшее число", a);
        Console.WriteLine("{0} наименьшее число", b);
 
    }
 
    else
 
    {
 
        Console.WriteLine("{0} наибольшее число", b);
        Console.WriteLine("{0} наименьшее число", a);
 
    }
 
Console.ReadLine();
*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
 
/*

int m1, m2, m3;


Console.WriteLine("Введите три числа: ");

m1 = Convert.ToInt32(Console.ReadLine());
m2 = Convert.ToInt32(Console.ReadLine());
m3 = Convert.ToInt32(Console.ReadLine());

int max = m2;

if (m1 > m2)
{
   Console.WriteLine("maximal number {0} ", m1);
}
if(m3 > max)
{
    Console.WriteLine("maximal number {0} ", m3);
}
else    
    {
        Console.WriteLine("maximal number {0} ", m2);
    }

Console.ReadLine();

*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
//-3 -> нет
//7 -> нет

/*

int num;

Console.Write("Напишите число:");
num = Convert.ToInt32(Console.ReadLine());


if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} являеться четным");
}
else
{
    Console.WriteLine($"Число {num} не являеться четным");
}
Console.ReadLine();

*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*

int num;

  int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num);
            while (i <= num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
*/
