using System;

namespace BubbleSort
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] arr = { 89, 23, 65, 12, 543, 62, 3, 90 };
            int elementsCount = arr.Length;
            int temp;
            for (int i = 0; i < elementsCount; i++)
            {
                for (int j = 0; j < elementsCount-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
