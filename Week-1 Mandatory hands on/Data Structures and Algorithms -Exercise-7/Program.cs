using System;
class Program
{
    static double ForecastValueRecursive(double c, double g, int y)
    {
        if (y == 0)
            return c;
        return ForecastValueRecursive(c, g, y - 1) * (1 + g);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter current value:");
        double cv= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter growth rate (e.g. 0.05 for 5%):");
        double gr = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter number of years:");
        int y = Convert.ToInt32(Console.ReadLine());
        double fv= ForecastValueRecursive(cv, gr, y);
        Console.WriteLine($"\nFuture Value (Recursive): {fv:F2}");
    }
}
