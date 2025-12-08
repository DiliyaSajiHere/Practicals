using System;
using System.Text;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        if (value <= 0 || value >= 4000)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Roman numerals support the range 1-3999.");
        }
        
        (int Value, string Symbol)[] symbols =
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I"),
        };

        var result = new StringBuilder();
        int remaining = value;

        foreach (var (threshold, symbol) in symbols)
        {
            while (remaining >= threshold)
            {
                result.Append(symbol);
                remaining -= threshold;
            }
        }

        return result.ToString();
    }
}