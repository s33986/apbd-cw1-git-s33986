// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        countToTen();
        
        int z = power(2, 3);

        if (z%2 ==0)
        {
            printNTimes(z, "APBD");
        }
    }


    static void countToTen()
    {
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void printNTimes(int n, string s)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(s);
        }
    }

    static int power(int n, int k)
    {
        int result = 1;
        for (int i = 0; i < k; i++)
        {
            result *= n;
        }
        return result;
    }

    static double calculateAverage(int[] values)
    {
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        double average = sum / values.Length;
        return average;
    }

    static int CalculateMax(int[] values)
    {
        int max = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }
        return max;
    }

    static int CalculateMin(int[] values)
    {
        int min = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] < min)
            {
                min = values[i];
            }
        }
        return min;
    }
}