
using System.Reflection.Metadata.Ecma335;

namespace AverageCalculator;

public class AverageCalculator
{
    private double[] collection = { 0 };
    private Int64 count = 0;

    public AverageCalculator()
    {

    }
    public void add(double value)
    {
        collection[count] = value;
        count++;
    }
    public void add(double[] values)
    {
        double? test_null = values[0];
        if (!test_null.HasValue)
        {
            Console.WriteLine("Bitte ein Array mit Werten!");
        }
        else
        {
            Int64 i = 0;
            while (i > values.Length)
            {
                add(values[i]);
                i++;
            }  
        }
        
    }
    public void getAverage()
    {
        if (collection[0] == double.NaN)
        {
            
        }
    }

}
