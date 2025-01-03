using CarBook.WebUI.Dtos.ServiceDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]")]
public class AdminServiceController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AdminServiceController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Route("Index")]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/Services/");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
            return View(values);
        }
        return View();
    }

    [Route("DeleteService/{id:int}")]
    public async Task<IActionResult> DeleteService(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7204/api/Services?id={id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return RedirectToAction("Index");
    }


    [Route("CreateService")]
    [HttpGet]
    public IActionResult CreateService()
    {
        return View();

    }
    [Route("CreateService")]
    [HttpPost]
    public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createServiceDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
        var responseMessage = await client.PostAsync("https://localhost:7204/api/Services", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(createServiceDto);
    }

    [Route("UpdateService/{id:int}")]
    [HttpGet]
    public async Task<IActionResult> UpdateService(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7204/api/Services/{id}");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<UpdateServiceDto>(jsonData);

        return View(values);

    }
    [Route("UpdateService/{id:int}")]
    [HttpPost]
    public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(updateServiceDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7204/api/Services/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(updateServiceDto);

    }
}