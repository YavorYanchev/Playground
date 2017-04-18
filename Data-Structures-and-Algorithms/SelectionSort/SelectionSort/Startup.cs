using System;

namespace SelectionSort
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var arr = new int[] {345,23,98,53,74,21,905,44 };
            var elementsCount = arr.Length;
            int tempMinIndex;
            int temp;
            for (int i = 0; i < elementsCount-1; i++)
            {
                tempMinIndex = i;
                for (int j = i+1; j < elementsCount; j++)
                {
                    if (arr[j] < arr[tempMinIndex])
                    {
                        tempMinIndex = j;
                    }
                }
                //swap
                temp = arr[i];
                arr[i] = arr[tempMinIndex];
                arr[tempMinIndex] = temp;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
