using System;

namespace ExtraTask_001
{
    class Program
    { 
        static void ShowCreatedArray(int[] arr)
        {
            Console.Write("Your created array is ");
            foreach (var value in arr)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n");
        }

        static void ShowReversedArrayElements(int[] arr) 
        {
            Console.Write("Elements in Reversed order is ");
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5] {1, 2, 7, 9, 5};
            ShowCreatedArray(arr);
            ShowReversedArrayElements(arr);

            //Delay
            Console.ReadKey();
        }
    }
}
