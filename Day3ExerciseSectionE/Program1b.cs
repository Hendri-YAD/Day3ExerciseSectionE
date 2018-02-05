using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionE
{
    class Program1b
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;


            for (int i = n; i >= 2; i--)
            {
                sum = sum * i;
            }

            Console.WriteLine("factorial of the number is: {0:#,##0}", sum);
        }
    }
}
