using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masycoda_test
{
    class Program
    {

        static void product(int[] arr,int n)
        {
            if(n==1)
            {
                Console.Write(0);
                return;
            }

            //initialize memory allocation to all arrays

            int[] left = new int[n];
            int[] right = new int[n];
            int[] prod = new int[n];

            int i, j;

            left[0] = 1;

            right[n - 1] = 1;

            //left array
            for (i = 1; i < n; i++)
                left[i] = arr[i - 1] * left[i - 1];

            //right array
            for (j = n - 2; j >= 0; j--)
                right[j] = arr[j + 1] * right[j + 1];

            //product of left & right
            for (i = 0; i < n; i++)
                prod[i] = left[i] * right[i];

            //print the product
            for (i = 0; i < n; i++)
                Console.Write(prod[i] + "");

            return;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            Console.Write("The Product Array Is:");
            product(arr, n);

            //to hold the output screen
            Console.ReadKey();
            
        }
    }
}
