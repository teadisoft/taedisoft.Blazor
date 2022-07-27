namespace taedisoft.BlazorServer.Models
{
    public class WeatherForecastModel
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public bool Precipitation { get; set; }
        public string? Forecast { get; set; }
        public double TemperatureF => Math.Round((TemperatureC * 1.8 + 32), 2);
        public string? CloudCover { get; set; }
    }
}
