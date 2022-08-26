// -------- Задача 1 ---------------
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int secNum = Convert.ToInt32(Console.ReadLine());

// if (firstNum > secNum)
// {
//     Console.WriteLine("max = " + firstNum + "; " + "min = " + secNum);
// }
// else Console.WriteLine("max = " + secNum + "; " + "min = " + firstNum);

// -------- Задача 2 ---------------
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int N3 = Convert.ToInt32(Console.ReadLine());

if (N1 > N2 && N1 > N3) 
{
      Console.WriteLine("max = " + N1);
}
else if (N2 > N1 && N2 > N3)
{
    Console.WriteLine("max = " + N2);
}
else Console.WriteLine("max = " + N3);