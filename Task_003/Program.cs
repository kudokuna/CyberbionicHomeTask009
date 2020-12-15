using System;

namespace Task_003
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

        static int[] MyReverse(int[] array) 
        {
            int[] shiftedArray = new int[array.Length];

            int holder = 0;
            int size = array.Length;
            for (int i = 0; i < size / 2; ++i)
            {
                holder = array[i];
                shiftedArray[i] = array[size - 1 - i];
                shiftedArray[size - 1 - i] = holder;
            }

            return shiftedArray;
        }
        static int[] SubArray(int[] array, int index, int count) 
        {   
            // вспомогательная переменная счетчик
            int counter = 0;
            // счетчик для нахождения последнего не заполненного элемента
            int lastElement = 0;
            // создаем временный(буферный массив), его размерносоть (размерность основного - позиция вырезки)
            int[] tempArray = new int[array.Length - (index)];
            // Создаем результирующий массив размерпность которого будет равнятся заданной в count
            int[] resultedArray = new int[count];

            // заполняем временный массив 
            for (int i = index; i < array.Length; i++)
            {
                tempArray[counter] = array[i];
                counter++;
            }

            // заполняем итоговый массив элементами из буферного массива
            for (int i = 0; i < tempArray.Length; i++)
            {
                resultedArray[i] = tempArray[i];
                lastElement++;
            }
            // заполняем единицами оставшиеся элементы
            if (!(lastElement == resultedArray.Length - 1))
            {
                for (int i = lastElement; i < resultedArray.Length; i++)
                {
                    resultedArray[i] = 1;
                }
            }

            return resultedArray;
        }

        static void Main(string[] args)
        {
            int[] arr = new int [10] {1, 2, 4, 5, 6, 8, 9, 12, 18, 18};
            ShowCreatedArray(arr);
            int[] shiftedArray = MyReverse(arr);
            ShowCreatedArray(shiftedArray);
            int[] extendedArray = SubArray(arr, 5, 5);
            ShowCreatedArray(extendedArray);
        }
    }
}
