using BlazorApi.Client.Data;

namespace BlazorApi.Client.Services;

public abstract class BaseLocalApiService
{
    public const string DEFAULT_HTTP_CLIENT_NAME = "BaseLocalApiService";
    protected HttpClient _client { get; }
    public BaseLocalApiService(IHttpClientFactory factory)
    {
        _client = factory.CreateClient(DEFAULT_HTTP_CLIENT_NAME);
    }
}