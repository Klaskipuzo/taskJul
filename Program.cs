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
                var interA = int.Parse(Console.ReadLine());
                var interB = int.Parse(Console.ReadLine());
                var sum = 0;
                for (int i = interA; i <= interB; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum = i + sum * sum * sum * sum;
                    }

                }
                Console.WriteLine($"Сумма положительных чисел из промежутка введенных чисел: {sum}");
            }

            static void Task4()
            {
                int[] myArray = new int[10000];

                //Составить программу поиска четырехзначных чисел, которые при делении на 47 дают в остатке 43, а при делении на 43 дают в остатке 37.
                var in1 = 0;
                var in2 = 0;

                for (int i = 1000; i < myArray.Length; i++)
                {


                    if (i % 47 == 43)
                    {
                        in1 = i;
                        Console.WriteLine($"Перый диапазон чисел деленных на 47 и дающих в остатке 43: {in1}");
                    }
                    else if (i % 43 == 37)
                    {
                        in2 = i;
                        Console.WriteLine($"Второй диапазон чисел деленных на 43 и дающих в остатке 37 : {in2}");
                    }
                }
            }

            static void Task5()
        {
            //Составить программу поиска четырехзначных чисел, которые при делении на 133 дают в остатке 125, а при делении на 134 дают в остатке 111.

            int[] myArray = new int[10000];


            var in1 = 0;
            var in2 = 0;

            for (int i = 1000; i < myArray.Length; i++)
            {


                if (i % 133 == 125)
                {
                    in1 = i;
                    Console.WriteLine($"Перый диапазон чисел деленных на 133 и дающих в остатке 125: {in1}");
                }
                else if (i % 134 == 111)
                {
                    in2 = i;
                    Console.WriteLine($"Второй диапазон чисел деленных на 134 и дающих в остатке 111 : {in2}");
                }

            }
        }
        
    }

}

