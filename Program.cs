using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{

    class Program
    {
        static void Main(string[] args)
        {
            //    int firstNumber, secondNumber;
            //    bool isParse;

            //   Console. WriteLine(" введите две цифры для деление: \n");

            //    Console.WriteLine("Введите 1 цифру: \n");

            //    isParse = int.TryParse(Console.ReadLine(), out firstNumber);

            //    Console.WriteLine("\n Введите 2 цифру: \n");

            //    isParse = int.TryParse(Console.ReadLine(), out secondNumber);

            //    CheckProblem(firstNumber, secondNumber);

            //    Console.ReadKey();
            //}

            //private static void CheckProblem(int firstNumber, int secondNumber)
            //{
            //    try
            //    {
            //        DivizionByZero(firstNumber, secondNumber);
            //    }
            //    catch (ArgumentNullException argumentNullException)
            //    {
            //        Console.WriteLine(argumentNullException);
            //    }
            //    catch (ArithmeticException arithmeticException)
            //    {
            //        Console.WriteLine(arithmeticException);
            //    }
            //}
            //private static int DivizionByZero(int firstNumber, int secondNumber)
            //{
            //    int sum;
            //    sum = firstNumber / secondNumber;
            //    return sum;
            //}
            int[] arr = new int[5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                arr[i] = rand.Next(1, 10);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\n");
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine(); 
        }
    }
}
