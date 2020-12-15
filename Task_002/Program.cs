using System;

namespace Task_002
{
    class Program
    {

        static void DefineArrayLenght(out int arrLenght) 
        {
            while (true)
            {
                Console.WriteLine("Please define Array length");
                if (!int.TryParse(Console.ReadLine(), out arrLenght))
                {
                    Console.WriteLine("Wrong input");
                }
                else break;
            }
        }
        static int[] FillArray(int[] sourceArray) 
        {
            Random rnd = new Random();

            for (int i = 0; i < sourceArray.Length; i++)
            {
                sourceArray[i] = rnd.Next(-5,66);
            }

            return sourceArray;
        }
        static void ShowCreatedArray(int[] arr) 
        {
            foreach (var value in arr)
            {
                Console.Write(value+" ");
            }
            Console.Write("\n");
        }
        static void ShowBiggestElement(int[] arr) 
        {
            int temp = default;
            foreach (var value in arr)
            {
                if (temp <= value) 
                {
                    temp = value;
                }
            }

            Console.WriteLine($"The biggest element is {temp}");
        }
        static void ShowLowestElement(int[] arr)
        {
            int temp = default;
            foreach (var value in arr)
            {
                if (value <= temp)
                {
                    temp = value;
                }
            }

            Console.WriteLine($"The lowest element is {temp}");
        }
        static void ShowSumOfArrayElements(int[] arr) 
        {
            int sum = default;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine($"Summ of all elements is {sum}");
        }
        static void ShowMiddleArifmetical(int[] arr) 
        {
            int sum = default;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine($"Middle Ariphmetical of all elements is {sum/arr.Length}");
        }
        static void ShowOnlyNotEvenElements(int[] arr) 
        {
            Console.Write("All Not even elements are: ");
            foreach (var element in arr)
            {
                if ((element & 1) != 0)
                {
                    Console.Write(element + " ");
                }
            }
        }


        static void Main(string[] args)
        {
            int arrLenght;
            DefineArrayLenght(out arrLenght);
            int[] arr = new int[arrLenght];
            FillArray(arr);
            ShowCreatedArray(arr);
            ShowBiggestElement(arr);
            ShowLowestElement(arr);
            ShowSumOfArrayElements(arr);
            ShowMiddleArifmetical(arr);
            ShowOnlyNotEvenElements(arr);

            //Delay
            Console.ReadLine();
        }
    }
}
