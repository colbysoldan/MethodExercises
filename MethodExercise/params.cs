using System;
namespace MethodExercise
{
	public class Params
	{
        //param keyword
        public static int AnyLengthSum(params int[] list)
        {
            int sum = list[0];
            for (int i = 1; i < list.Length; i++)
                sum += list[i];
            return sum;
        }

        public static int AnyLengthDif(params int[] list)
        {
            int difference = list[0];
            for (int i = 1; i < list.Length; i++)
                difference -= list[i];
            return difference;
        }

        public static int AnyLengthProd(params int[] list)
        {
            int product = list[0];
            for (int i = 1; i < list.Length; i++)
                product *= list[i];
            return product;
        }

        public static int AnyLengthQuo(params int[] list)
        {
            int quotient = list[0];
            for (int i = 1; i < list.Length; i++)
                quotient /= list[i];
            return quotient;
        }
        //---------------------------------//


        public Params()
		{
		}
	}
}

