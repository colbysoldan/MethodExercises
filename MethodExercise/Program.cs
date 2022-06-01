using System;

namespace MethodExercise
{
    class Program
    {
        
        ///Exercise 2 methods//////
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        //Parameter methods are on params.cs sheet

        static void Main(string[] args)
        {
            //Exercise 1

            MadLib.MadLibStory();


            //Exercise 2

            
            Console.WriteLine(Add(4, 5));

            Console.WriteLine(Subtract(8, 5));

            Console.WriteLine(Multiply(5, 7));

            Console.WriteLine(Divide(8, 2));

            Console.WriteLine(Params.AnyLengthSum(1, 2, 4, 67, 42));

            Console.WriteLine(Params.AnyLengthDif(1, 2, 4, 67, 42));

            Console.WriteLine(Params.AnyLengthProd(7, 3, 8, 2));

            Console.WriteLine(Params.AnyLengthQuo(16, 2, 2, 2));

            Console.ReadLine();
        }
    }
}

