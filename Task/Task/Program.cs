using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir ədəd daxil edin:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num))
        {
            Console.WriteLine(num + " sadə ədəddir.");
        }
        else
        {
            Console.WriteLine(num + " mürəkkəb ədəddir.");
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
