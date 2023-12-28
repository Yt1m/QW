using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Числа Армстронга состоящие из трех и четырех цифр:");

        for (int num = 100; num <= 9999; num++)
        {
            int n = CountDigits(num);
            int sum = 0;
            int temp = num;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, n);
                temp /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine(num);
            }
        }
    }

    static int CountDigits(int num)
    {
        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }
}
