using System;
using System.Collections.Generic;

public class Forecaster
{
    private double initialRupees;
    private double growthRate;

    // Store already calculated years to avoid repeat work
    private Dictionary<int, double> memo = new Dictionary<int, double>();

    public Forecaster(double initialRupees, double growthRate)
    {
        this.initialRupees = initialRupees;
        this.growthRate = growthRate;
    }

    // Predict recursively with memoization
    public double Predict(int yearsAhead)
    {
        if (yearsAhead == 0)
            return initialRupees;

        if (memo.ContainsKey(yearsAhead))
            return memo[yearsAhead];

        double previous = Predict(yearsAhead - 1);
        double result = previous * (1 + growthRate);
        memo[yearsAhead] = result;
        return result;
    }
}

class Program
{
    static void Main()
    {
        double startingRupees = 15000;
        double yearlyGrowth = 0.05;
        int yearsToPredict = 6;

        var myForecaster = new Forecaster(startingRupees, yearlyGrowth);

        Console.WriteLine("Financial Forecast (in Rupees):");
        for (int year = 0; year <= yearsToPredict; year++)
        {
            double value = myForecaster.Predict(year);
            Console.WriteLine($"Year {year}: Rs {value:F2}");
        }
    }
}
