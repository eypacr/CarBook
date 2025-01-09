using CarBook.WebUI.Dtos.CarPricingsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.DashboardComponents;

public class _DashboardCarPricingListComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DashboardCarPricingListComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/CarPricings");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<CarPricingListDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}