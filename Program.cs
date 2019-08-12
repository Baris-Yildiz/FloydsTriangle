using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floyds_Triangle_CS
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("How many rows? :");

            int GivenRow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Floyd:" + Environment.NewLine);

            int row = 1;

            int number = 1;

            while(row <= GivenRow)
            {
                for(int i = 0; i<row; i++)
                {
                    Console.Write(number + " ");
                    number += 1;
                }
                Console.WriteLine();

                row += 1;
            }

            row -= 1;

            number -= 1;

            Console.WriteLine(Environment.NewLine + "Reverse Floyd:" + Environment.NewLine);

            while(row >= 1)
            {
                for(int i = 0; i<row; i++)
                {
                    Console.Write(number + " ");
                    number -= 1;
                }

                Console.WriteLine();

                row -= 1;
            }
        }
    }
}
