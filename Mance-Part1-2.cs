using System;
namespace LargestElementInArray
{
    class Compare
    {
        static void Main(string[] args)
        {
            int[] Arr1 = { 25, 16, 50, 82, 45 };
            Console.WriteLine("Numbers within the Array: ");
            foreach (int num in Arr1)
            {
                Console.WriteLine(num);
            }
            int bigger = Arr1[0];
            for (int i = 1; i < Arr1.Length; i++)
            {
                if (Arr1[i] > bigger)
                {
                    bigger = Arr1[i];
                }
            }
            Console.WriteLine("The largest element in the array is: " + bigger);
            Console.ReadKey();
        }
    }
}

