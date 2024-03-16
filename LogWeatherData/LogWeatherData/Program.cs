using Iot.Device.Common;
using Iot.Device.SenseHat;
using (var th = new SenseHatTemperatureAndHumidity())
{
    while (true)
    {
        var tempValue = th.Temperature;
        var humValue = th.Humidity;

        Console.WriteLine($"Temperature: {tempValue:0.#}\u00B0C");
        Console.WriteLine($"Relative humidity: {humValue:0.#}%");

        // WeatherHelper supports more calculations, such as saturated vapor pressure, actual vapor pressure and absolute humidity.
        Console.WriteLine($"Heat index: {WeatherHelper.CalculateHeatIndex(tempValue, humValue):0.#}\u00B0C");
        Console.WriteLine($"Dew point: {WeatherHelper.CalculateDewPoint(tempValue, humValue):0.#}\u00B0C");

        Thread.Sleep(1000);
    }
}