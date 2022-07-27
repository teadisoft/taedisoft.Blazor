using Microsoft.AspNetCore.Components;
using taedisoft.BlazorServer.Models;

namespace taedisoft.BlazorServer.Pages.Dx
{
    public partial class BlazorDataGrid : ComponentBase
    {
        async Task OnRowRemoving(WeatherForecastModel dataItem)
        {
            await ForecastService.Remove(dataItem);
        }
        async Task OnRowUpdating(WeatherForecastModel dataItem, IDictionary<string, object> newValue)
        {
            await ForecastService.Update(dataItem, newValue);
        }
        async Task OnRowInserting(IDictionary<string, object> newValue)
        {
            await ForecastService.Insert(newValue);
        }
        Task OnInitNewRow(Dictionary<string, object> values)
        {
            values.Add("Date", DateTime.Now);
            values.Add("TemperatureC", 13);
            values.Add("Forecast", "Warm");
            values.Add("CloudCover", "Sunny");
            return Task.CompletedTask;
        }
    }
}
