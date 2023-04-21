// Console.WriteLine ("Таблица умножения:");
// for (int i = 10; i >=2; i--)
// {
//     Console.WriteLine($"умножение на {i}" );
//     for (int u = 10; u >= 2; u-- )
//     {


//         Console.WriteLine($"{i}x{u}={u * i}");

//     }
// } 

// Console.WriteLine("Введите слово:");
// string txt = Console.ReadLine();
// char[]chairA = txt.ToCharArray();

// for( int c = txt.Length - 1; c >= 0; c--)
// {
//     // int i = c;
//     Console.Write(txt[c]);

// }

// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число:");
// string one = Console.ReadLine();
// int two = Convert.ToInt32(one);

// Console.WriteLine("Введите степень:");
// string st = Console.ReadLine();
// int three = Convert.ToInt32(st);
// int q = two;

//     for(int i = 1; i < three; i++)
//     {
//     q = q * two;

//     }


// Console.WriteLine(q);


// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число:");

// string text = Console.ReadLine();
// // int[] cifrA = Convert.ToInt32(text);


// char[]one = text.ToCharArray();
// int sum = 0;
// for (int i = 0, sum2 = 0; i < one.Length; i++)
// {
//     // Console.WriteLine(one[i]);

//     sum2 = Convert.ToInt32 (one[i] - 48);
//     sum = sum + sum2;


// }
// Console.WriteLine(sum);


// Задача 29: Напишите программу, которая задаёт массив из
//  8 элементов (от -10 до 10) и выводит их на экран.

// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]
// 6, 1, 3 -> [6, 1, 3]


// Console.Write("Массив из 8 чисел:");
// int[] array = new int[8];
// for (int i = 0; i < 8; i++)
//     {
//     int numberOfmass = new Random().Next(-10, 10);
//     array[i] = numberOfmass;
//     Console.Write($"{array[i]},");
//     }


