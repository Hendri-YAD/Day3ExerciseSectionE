using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionE
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == num)
                Console.WriteLine("Perfect Number");
            else
                Console.WriteLine("Not a Perfect Number");
        }
    }
}
