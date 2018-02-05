using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3ExerciseSectionE
{
    class Program2
    {
        static void Main(string[] args)
        {
            double no = 1.0, inv = 1.0, sqr = 1.0, squ = 1.0;

            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine("{0:0.0##}\t{1:0.0##}\t{2:0.0##}\t{3:0.0##}", no, inv, sqr, squ);
                no++;
                inv = 1 / no;
                sqr = Math.Sqrt(no);
                squ = Math.Pow(no, 2);
            }
        }
    }
}
