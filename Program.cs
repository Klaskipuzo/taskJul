using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        }

        static void Task1()
        {
            int[] myArray = { 33, 23, 3, 23, 12, 31, 24, 124 };
            Random random = new Random();
            var min = myArray[0];


            for (int i = 1; i < myArray.Length; i++)
            {

                if (myArray[i] < min)
                {
                    min = myArray[i];
                }

            }
            Console.WriteLine(min);
        }

        static void Task2()
        {
            //Найти сумму положительных нечетных чисел, меньших 50
            int[] myArray = new int[100];

            var sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (i < 50)
                    {
                        sum = sum + i;
                        Console.WriteLine(i);
                    }
                }
                else
                {

                }

            }
            Console.WriteLine($"Сумма всех нечетных чисел до 50" + sum);
        }

        static void Task3()
        {

        }
    }
}

