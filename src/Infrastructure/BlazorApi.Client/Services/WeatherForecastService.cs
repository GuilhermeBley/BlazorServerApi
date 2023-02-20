using BlazorApi.Client.Data;

namespace BlazorApi.Client.Services;

public class WeatherForecastService : BaseLocalApiService
{
    public WeatherForecastService(IHttpClientFactory factory) : base(factory)
    {
    }

    public async Task<IEnumerable<WeatherForecast>> GetForecastAsync(DateTime startDate)
        => await _client.GetFromJsonAsync<IEnumerable<WeatherForecast>>("api/WeatherForecast")
            ?? Enumerable.Empty<WeatherForecast>();
}
