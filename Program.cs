// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main()
    {
        countToTen();
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
}