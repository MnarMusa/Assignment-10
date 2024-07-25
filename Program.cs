
using System;

class Program
{
    #region P-1
    static void OptimizedBubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                   
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

          
            if (!swapped)
                break;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    #endregion

    #region P-2
    public class Range<T> where T : IComparable<T>
    {
        public T Minimum { get; private set; }
        public T Maximum { get; private set; }

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum value cannot be greater than the maximum value.");
            }
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        public T Length
        {
            get
            {
                dynamic min = Minimum;
                dynamic max = Maximum;
                return max - min;
            }
        }
    } 
    #endregion



    public static void Main()
    {

        #region P-2
        Range<int> intRange = new Range<int>(1, 10);
        Console.WriteLine($"Range: {intRange.Minimum} to {intRange.Maximum}");
        Console.WriteLine($"Is 5 in range? {intRange.IsInRange(5)}");
        Console.WriteLine($"Is 0 in range? {intRange.IsInRange(0)}");
        Console.WriteLine($"Length of range: {intRange.Length}");

        Range<double> doubleRange = new Range<double>(1.5, 9.5);
        Console.WriteLine($"\nRange: {doubleRange.Minimum} to {doubleRange.Maximum}");
        Console.WriteLine($"Is 5.5 in range? {doubleRange.IsInRange(5.5)}");
        Console.WriteLine($"Is 10.0 in range? {doubleRange.IsInRange(10.0)}");
        Console.WriteLine($"Length of range: {doubleRange.Length}");


        Range<DateTime> dateRange = new Range<DateTime>(new DateTime(2020, 1, 1), new DateTime(2021, 1, 1));
        Console.WriteLine($"\nRange: {dateRange.Minimum} to {dateRange.Maximum}");
        Console.WriteLine($"Is 2020-06-01 in range? {dateRange.IsInRange(new DateTime(2020, 6, 1))}");
        Console.WriteLine($"Is 2022-01-01 in range? {dateRange.IsInRange(new DateTime(2022, 1, 1))}");
        Console.WriteLine($"Length of range: {(dateRange.Maximum - dateRange.Minimum).Days} days"); 
        #endregion


    }
}
