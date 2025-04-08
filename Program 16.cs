using System;

class Boiler
{
    public int Temp { get; set; }
    public int Pressure { get; set; }
    public int WaterLevel { get; set; }

    public delegate void AlertHandler(string message);
    public event AlertHandler Alert;

    public void CheckBoiler()
    {
        if (Temp > 100 || Pressure > 150 || WaterLevel > 80)
        {
            Alert?.Invoke("ALERT: One or more boiler levels are above the safety limit!");
        }
        else
        {
            Console.WriteLine("Boiler is operating within safe parameters.");
        }
    }
}

class Program
{
    static void Main()
    {
        Boiler boiler = new Boiler();

        boiler.Alert += (message) => Console.WriteLine(message);

        Console.Write("Enter Temperature: ");
        boiler.Temp = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Pressure: ");
        boiler.Pressure = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Water Level: ");
        boiler.WaterLevel = Convert.ToInt32(Console.ReadLine());

        boiler.CheckBoiler();
    }
}
