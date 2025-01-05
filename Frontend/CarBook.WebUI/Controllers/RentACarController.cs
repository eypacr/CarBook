using CarBook.WebUI.Dtos.CarDtos;
using CarBook.WebUI.Dtos.FilterRentACarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Controllers;

public class RentACarController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public RentACarController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public IActionResult Index()
    {
        ViewBag.v1 = "Araç Kirala";
        ViewBag.v2 = "Aracınızı Kiralayın";
        return View();
    }
    public async Task<IActionResult> List(FilterRentACarDto dto)
    {
        ViewBag.v1 = "Filtrelenen Araçlar ";
        ViewBag.v2 = "Filtrelenen Araçlar ";
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7204/api/RentACars", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonDats = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<CarListDto>>(jsonDats);
            return View(values);
        }
        return View();
    }

}
