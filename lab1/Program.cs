// See https://aka.ms/new-console-template for more information

public class HW1
{
    public static long QueueTime(int[] customers, int n)
    {
        int element = Int32.MaxValue;
        int i = 0;
        int index = -1;
        int[] cash = new int[n];
        for (i = 0; i < n; i++)
        {
            cash[i] = customers[i];
        }
        while (i < customers.Length)
        {
            for (int j = 0; j < cash.Length; j++)
            {
                if (cash[j] < element)
                {
                    element = cash[j];

                    index = j;
                }
            }
            cash[index] += customers[i];
            i++;
        }
        for (int j = 0; j < cash.Length; j++)
        {
            if (cash[j] > element)
            {
                element = cash[j];

                index = j;
            }
        }
        return element;
    }
}

namespace lab1 {
    static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Тест 1: [5,3,4], 1 - ");
            Console.WriteLine(HW1.QueueTime(new int[] { 5, 3, 4 }, 1));

            Console.WriteLine("Тест 2: [10,2,3,3], 2 - ");
            Console.WriteLine(HW1.QueueTime(new int[] {10,2,3,3},2));

            Console.WriteLine("Тест 3: [2,3,10], 2 - ");
            Console.WriteLine(HW1.QueueTime(new int[] { 2,3,10 }, 2));
        }
    }
}