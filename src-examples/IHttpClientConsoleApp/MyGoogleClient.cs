using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IHttpClientConsoleApp;

public class MyGoogleClient
{
    private readonly HttpClient _httpClient;

    public MyGoogleClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://google.com");

    }

    public async Task GetAsync()
    {
        var response = await _httpClient.GetAsync("imghp");
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine(json);
        }
        else
        {
            Console.WriteLine($"Request failed: {response.StatusCode}");
        }
    }
}