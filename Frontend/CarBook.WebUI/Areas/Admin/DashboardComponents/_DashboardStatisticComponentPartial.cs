using CarBook.WebUI.Dtos.StatisticDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.DashboardComponents;

public class _DashboardStatisticComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DashboardStatisticComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/Statistics");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var value = JsonConvert.DeserializeObject<ResultStatisticDto>(jsonData);
        return View(value);
    }
}
