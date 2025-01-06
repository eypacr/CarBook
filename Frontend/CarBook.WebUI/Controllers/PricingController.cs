using CarBook.WebUI.Dtos.CarPricingsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers;

public class PricingController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public PricingController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.v1 = "Fiyatlar";
        ViewBag.v2 = "Fiyatlar";
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