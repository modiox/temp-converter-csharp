using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Enter a temperature and its unit (C or F): or type 'End' to quit the app..");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                if (input.ToLower() == "end")
                {
                    Console.WriteLine("You've exited the app..");
                    break;
                }

                if (parts.Length != 2)
                {
                    Console.WriteLine("Invalid input format. Please enter temperature followed by unit (C or F).");
                    continue;
                }

                string tempUnit = parts[1].ToUpper().Trim();
                if (tempUnit != "F" && tempUnit != "C")
                {
                    Console.WriteLine("Invalid unit format. Please enter C or F unit.");
                    continue;
                }

                double temperature;
                if (!double.TryParse(parts[0], out temperature))
                {
                    Console.WriteLine("Invalid temperature value. Please enter a valid number.");
                    continue;
                }

                string converted = TempConvert(temperature, tempUnit);
                Console.WriteLine($"Converted: {input} = {converted}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    static string TempConvert(double temperature, string originalUnit)
    {
        double convertedTemperature;
        string newUnit;
        if (originalUnit == "C")
        {
            convertedTemperature = (temperature * 9 / 5) + 32;
            newUnit = "F";
        }
        else
        {
            convertedTemperature = (temperature - 32) * 5 / 9;
            newUnit = "C";
        }
        return $"{convertedTemperature:F2} {newUnit}";
    }
}
