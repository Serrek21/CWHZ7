using System;
using System.Linq;
class Program
{
    delegate bool Prov(int n);
    delegate int Kva(int n);
    delegate int Kub(int n);
    delegate bool Day(DateTime date);

    static void Main()
    {
        //1
        Prov par = (n) =>
        {
            return n % 2 == 0;
        };

        int Test = 5;
        Console.WriteLine($"{Test} Парне: {par(Test)}");

        //2
        Kva squ = (n1) =>
        {
            return n1 * n1;
        };

        int Test2 = 5;
        Console.WriteLine($"Квадрат {Test2} це: {squ(Test2)}");

        //3
        Kub cube = n2 => n2 * n2 * n2;

        int Test3 = 3;
        Console.WriteLine($"Куб {Test3} це: {cube(Test3)}");

        //4
        Day day = date =>
        {
            return date.DayOfYear == 256;
        };

        DateTime dateTest = new DateTime(2023, 9, 13);
        Console.WriteLine($"{dateTest.ToShortDateString()} День програміста: {day(dateTest)}");

        DateTime dateTest2 = new DateTime(2024, 9, 13);
        Console.WriteLine($"{dateTest2.ToShortDateString()} День програміста: {day(dateTest2)}");

        //5
        Func<int[], int> find = n => n.Max();

        int[] Test5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine($"Саме велике число: {find(Test5)}");

        //6
        Func<int[], int> find1 = n => n.Min();

        int[] Test6 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine($"Саме маленьке число: {find1(Test5)}");

        //7
        Func<int[], int[]> findNePar = n => n.Where(n => n % 2 != 0).ToArray();

        int[] Test7 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var NeParN = findNePar(Test7);
        Console.WriteLine("Не парні числа в масиві:");
        foreach (var n in NeParN)
        {
            Console.WriteLine(n);
        }

    }
}