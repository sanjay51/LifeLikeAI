using System;
using System.Collections.Generic;
public class CreatureAction
{
    Dictionary<string, double> dictionary = new Dictionary<string, double>();

    public double getDoubleAttribute(string key)
    {
        double result = 0;
        dictionary.TryGetValue(key, out result);

        return result;
    }

    public void setDoubleAttribute(string key, double value)
    {
        dictionary.Add(key, value); 
    }
}
