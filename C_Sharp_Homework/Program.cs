using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число A = ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите число B = ");
            int B = int.Parse(Console.ReadLine());


            while (A <= B)
            {
                for (int j = 0; j < A; j++)
                {
                    Console.Write(A);
                }
                A++;
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
