using System;

class Program
{
    static void Main(string[] args)
    {
        double x, r;

        for (; ; )
        {
            Console.Write("Введите значение x (для выхода введите 0): ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x == 0)
                break;

            if (0 < x && x < 3.14)
                r = Math.Sin(x);
            else if (-3.14 <= x && x < 0)
                r = 3 * x;
            else if (x < -2 * 3.14 || x > 2 * 3.14)
                r = 2 * x;
            else
                r = 0;

            Console.WriteLine($"r = {r}\n");
        }

        Console.WriteLine("Программа завершена.");
        Console.ReadLine();
    }
}
