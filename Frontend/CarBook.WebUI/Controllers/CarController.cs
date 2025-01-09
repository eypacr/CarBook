using CarBook.WebUI.Dtos.CarPricingsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers;

public class CarController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public CarController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IActionResult> Index()
    {
			ViewBag.v1 = "Araçlarımız";
			ViewBag.v2 = "Aracınızı Seçiniz";
			var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/CarPricings/List");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultCarPricingWithCarDto>>(jsonData);
            return View(values);
        }
        return View();
    }
    public async Task<IActionResult> CarDetail(int id)
    {
        ViewBag.v1 = "Araba Detayı";
        ViewBag.v2 = "Araba Detayı";
        ViewBag.id = id;
        return View();
    }
}
