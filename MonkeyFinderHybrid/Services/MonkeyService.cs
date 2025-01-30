using System.Net.Http.Json;

namespace MonkeyFinderHybrid.Services;

public class MonkeyService
{
    private List<Monkey> monkeyList = new();

    private readonly HttpClient _httpClient;

    public MonkeyService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Monkey>> GetMonkeys()
    {
        if (monkeyList.Any())
        {
            return monkeyList;
        }

        var response = await _httpClient.GetAsync("https://montemagno.com/monkeys.json");

        if (response.IsSuccessStatusCode)
        {
            var monekeyResult = await response.Content.ReadFromJsonAsync(MonekeyContext.Default.ListMonkey);

            if (monekeyResult is not null)
            {
                monkeyList = monekeyResult;
            }
        }
        return monkeyList;
    }
}