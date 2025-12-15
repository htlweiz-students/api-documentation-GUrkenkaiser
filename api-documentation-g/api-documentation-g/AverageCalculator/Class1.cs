namespace Api;

public class AverageCalculator
{
    private double[] collection = {0};
    private Int64 count = 0;
    public void add(double value)
    {
        collection[count] = value;
        count++;
    }
    public void add(double[] values)
    {
        Int64 i = 0;
        while (i > values.Length)
        {
            add(values[i]);
            i++;
        }
    }
}
