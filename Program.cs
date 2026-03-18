// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        countToTen();
        
        int z = power(2, 3);
        
        printNTimes(z, "apbd");
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
}