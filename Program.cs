using System;

//генерируйте 10 объектов и отсортируйте в порядке убывания.

namespace DexCompareTo
{
    class Program
    {
        static void Main()
        {
            const int SIZE = 10;

            Random rand = new Random();
            Triangle[] triangle = new Triangle[SIZE];

            for (int i = 0; i < triangle.Length; i++)
            {
                try
                {
                    triangle[i] = new Triangle(rand.Next(3, 10), rand.Next(-3, 10), rand.Next(3, 10));
                    Console.WriteLine(triangle[i]);
                    Console.WriteLine($"Периметр треугольника = {triangle[i].СalcPerimeter():F}");
                    Console.WriteLine();
                }
                catch (IsNotTriangleException exception)
                {
                    Console.WriteLine(exception);
                    Console.WriteLine();
                    i--;
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Что-то действительно не так {exception}");
                    Console.WriteLine();
                    i--;
                }
            }

            PrintArray(triangle);

            Array.Sort(triangle);
            Array.Reverse(triangle);

            PrintArray(triangle);

            Console.ReadKey();
        }

        static void PrintArray(Triangle[] array)
        {
            Console.WriteLine(new string('=', 51));

            foreach (var item in array)
            {
                Console.WriteLine($"{item}: Периметр = {item.СalcPerimeter():F}");
            }
        }
    }
}
