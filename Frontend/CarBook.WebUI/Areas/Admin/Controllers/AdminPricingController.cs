using CarBook.WebUI.Dtos.PricingDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
[Route("Admin/[controller]")]
public class AdminPricingController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AdminPricingController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Route("Index")]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/Pricings/");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<PricingListDto>>(jsonData);
            return View(values);
        }
        return View();
    }

    [Route("DeletePricing/{id:int}")]
    public async Task<IActionResult> DeletePricing(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7204/api/Pricings?id={id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return RedirectToAction("Index");
    }


    [Route("CreatePricing")]
    [HttpGet]
    public IActionResult CreatePricing()
    {
        return View();

    }
    [Route("CreatePricing")]
    [HttpPost]
    public async Task<IActionResult> CreatePricing(PricingCreateDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
        var responseMessage = await client.PostAsync("https://localhost:7204/api/Pricings", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);
    }

    [Route("UpdatePricing/{id:int}")]
    [HttpGet]
    public async Task<IActionResult> UpdatePricing(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7204/api/Pricings/{id}");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<PricingUpdateDto>(jsonData);

        return View(values);

    }
    [Route("UpdatePricing/{id:int}")]
    [HttpPost]
    public async Task<IActionResult> UpdatePricing(PricingUpdateDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7204/api/Pricings/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);

    }
}
