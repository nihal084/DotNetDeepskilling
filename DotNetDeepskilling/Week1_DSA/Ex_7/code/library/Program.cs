using System;

class Program
{
    static void Main()
    {
        double initialValue = 10000; // Starting amount
        double growthRate = 0.1;     // 10% annual growth
        int years = 5;

        double futureValue = ForecastRecursive(initialValue, growthRate, years);
        Console.WriteLine($"📈 Predicted value after {years} years: ₹{futureValue:F2}");
    }

    static double ForecastRecursive(double initial, double rate, int years)
    {
        if (years == 0)
            return initial;

        return ForecastRecursive(initial, rate, years - 1) * (1 + rate);
    }
}
