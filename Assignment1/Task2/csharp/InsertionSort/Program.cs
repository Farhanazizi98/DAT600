// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

class Program
{
    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static int[] WorstCaseArray(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = n - i;
        return arr;
    }

    static void Main()
    {
        int[] nValues = { 1000, 2000, 4000, 8000, 12000, 20000 };

        foreach (int n in nValues)
        {
            int[] arr = WorstCaseArray(n);
            Stopwatch sw = Stopwatch.StartNew();
            InsertionSort(arr);
            sw.Stop();
            Console.WriteLine($"n={n}, time={sw.Elapsed.TotalSeconds:F4} s");
        }
    }
}
