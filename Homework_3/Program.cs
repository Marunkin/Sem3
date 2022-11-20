// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
Console.WriteLine ("Введите число: ");
string Numbers = Console.ReadLine()!;

if ((Numbers.Length) == 5)
{
    if (Numbers[0] == Numbers[4])
    {
        if (Numbers[1] == Numbers[3])
        {
            Console.WriteLine($"Число {Numbers} является полидромом!");
        }
        else
        {
            Console.WriteLine($"Число {Numbers} не является полидромом!");
        }
    }
    else
    {
        Console.WriteLine($"Число {Numbers} не является полидромом!");
    }
}
else
{
    Console.WriteLine($"Число не является 5-ым!");
}
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//1 вариант

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int n = 1;

while (n <= Math.Abs(number))
    {
        Console.Write($"{(n*n*n)} ");
        n++;
    }


//2 вариант
/*
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

for (int n = 1; n <= Math.Abs(number); n++)
    {
        Console.Write($"{Math.Pow(n,3)} ");
    }
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
Console.Write("Введите координату точки A: x1 = ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки A: y1 = ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки A: z1 = ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки B: x2 = ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки B: y2 = ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату точки B: z2 = ");
int z2 = int.Parse(Console.ReadLine()!);


double distance = Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2);
distance = Math.Sqrt(distance);

Console.WriteLine($"Расстояние между точками: {Math.Round(distance,2)}");
*/