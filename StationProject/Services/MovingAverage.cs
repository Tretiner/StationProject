namespace StationProject.Services;

using System;
using System.Collections.Generic;
using System.Linq;

public class MovingAverage
{
    private List<double> data;
    private int windowSize;

    public MovingAverage(List<double> initialData, int windowSize)
    {
        if (windowSize > initialData.Count)
        {
            throw new ArgumentException("Window size must be less than or equal to the length of the data");
        }

        this.data = new List<double>(initialData);
        this.windowSize = windowSize;
    }

    public List<double> CalculateMovingAverages()
    {
        var movingAverages = new List<double>();

        for (int i = 0; i <= data.Count - windowSize; i++)
        {
            var window = data.Skip(i).Take(windowSize).ToList();
            var avg = Math.Round(window.Average(), 2);
            movingAverages.Add(avg);
        }

        return movingAverages;
    }

    public double CalculateNextValue(List<double> movingAverages)
    {
        var lastAvg = movingAverages.Last();
        var lastDataValue = data.Last();
        var secondLastDataValue = data[data.Count - 2];

        var nextValue = Math.Round(lastAvg + (1.0 / windowSize) * (lastDataValue - secondLastDataValue), 2);
        data.Add(nextValue);

        return nextValue;
    }

    public void AddData(double value)
    {
        data.Add(value);
    }
}