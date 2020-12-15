using System;

namespace Task_004
{
    class Program
    {
        static void ShowCreatedArray(int[] arr)
        {
            foreach (var value in arr)
            {
                Console.Write(value + " ");
            }
            Console.Write("\n");
        }
        static int[] CreateAnotherArray(int[] arr, int value) 
        {
            int[] resultArray = new int[arr.Length + 1];
            resultArray[0] = value; 
            for (int i = 1; i < resultArray.Length; i++)
            {
                resultArray[i] = arr[i - 1];
            }

            return resultArray;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 3, 4, 6, 7, 8, 6, 5, 8, 12};

            ShowCreatedArray(arr);
            int[] newArr = CreateAnotherArray(arr, 99);
            ShowCreatedArray(newArr);
            //Delay
            Console.ReadKey();
        }
    }
}
