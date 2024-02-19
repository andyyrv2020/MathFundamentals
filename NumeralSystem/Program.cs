using System;

public class HexToDecimalConverter
{
    public static int ConvertHexToDecimal(string hexValue)
    {
        int decimalValue = Convert.ToInt32(hexValue, 16);
        return decimalValue;
    }
}

class Program
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();
        int decimalNumber = HexToDecimalConverter.ConvertHexToDecimal(hexNumber);
        Console.WriteLine($"Hexadecimal: {hexNumber} -> Decimal: {decimalNumber}");
    }
}