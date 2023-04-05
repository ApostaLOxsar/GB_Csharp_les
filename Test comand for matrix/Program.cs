using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System;

class QuickSortExample
{
    static void Main()
    {
        int[] arr = { 3, 7, 4, 2, 6, 1, 5 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        QuickSort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                QuickSort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                QuickSort(arr, pivot + 1, right);
            }
        }
    }

    static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
            {
                left++;
            }
            while (arr[right] > pivot)
            {
                right--;
            }
            if (left < right)
            {
                if (arr[left] == arr[right])
                {
                    return right;
                }

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
