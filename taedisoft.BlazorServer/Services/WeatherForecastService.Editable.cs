using taedisoft.BlazorServer.Models;

namespace taedisoft.BlazorServer.Services
{
    public partial class WeatherForecastService
    {
        WeatherForecastModel[] InsertInternal(IDictionary<string, object> newValue)
        {
            var dataItem = new WeatherForecastModel();
            Update(dataItem, newValue);
            Forecasts.Insert(0, dataItem);
            return Forecasts.ToArray();
        }
        public Task<WeatherForecastModel[]> Insert(IDictionary<string, object> newValue)
        {
            return Task.FromResult(InsertInternal(newValue));
        }
        WeatherForecastModel[] RemoveInternal(WeatherForecastModel dataItem)
        {
            Forecasts.Remove(dataItem);
            return Forecasts.ToArray();
        }
        public Task<WeatherForecastModel[]> Remove(WeatherForecastModel dataItem)
        {
            return Task.FromResult(RemoveInternal(dataItem));
        }
        WeatherForecastModel[] UpdateInternal(WeatherForecastModel dataItem, IDictionary<string, object> newValue)
        {
            foreach (var field in newValue.Keys)
            {
                switch (field)
                {
                    case nameof(dataItem.Date):
                        dataItem.Date = (DateTime)newValue[field];
                        break;
                    case nameof(dataItem.Forecast):
                        dataItem.Forecast = (string)newValue[field];
                        break;
                    case nameof(dataItem.TemperatureC):
                        dataItem.TemperatureC = (int)newValue[field];
                        break;
                    case nameof(dataItem.Precipitation):
                        dataItem.Precipitation = (bool)newValue[field];
                        break;
                    case nameof(dataItem.CloudCover):
                        dataItem.CloudCover = (string)newValue[field];
                        break;
                }
            }
            return Forecasts.ToArray();
        }
        public Task<WeatherForecastModel[]> Update(WeatherForecastModel dataItem, IDictionary<string, object> newValue)
        {
            return Task.FromResult(UpdateInternal(dataItem, newValue));
        }
    }
}
