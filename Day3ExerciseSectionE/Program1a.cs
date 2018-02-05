using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionE
{
    class Program1a
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;


            for (int i = 1; i <= n; i++)
            {
                sum = sum * i;
            }

            Console.WriteLine("factorial of the number is: {0:#,##0}", sum);
        }
    }
}
