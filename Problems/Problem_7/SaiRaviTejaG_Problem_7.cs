using System;

namespace Problem_Pal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input a number: ");
          n = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Sum: "(n*(n+1))/2);

          Console.ReadKey();

        }
    }
}
