using CarBook.WebUI.Dtos.LocationDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]")]
public class AdminLocationController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AdminLocationController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Route("Index")]
    public async Task<IActionResult> Index()
    {

        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/Locations/");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
            return View(values);
        }
        return View();



    }

    [Route("DeleteLocation/{id:int}")]
    public async Task<IActionResult> DeleteLocation(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7204/api/Locations?id={id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return RedirectToAction("Index");
    }


    [Route("CreateLocation")]
    [HttpGet]
    public IActionResult CreateLocation()
    {
        return View();

    }
    [Route("CreateLocation")]
    [HttpPost]
    public async Task<IActionResult> CreateLocation(CreateLocationDto createLocationDto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createLocationDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
        var responseMessage = await client.PostAsync("https://localhost:7204/api/Locations", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(createLocationDto);
    }

    [Route("UpdateLocation/{id:int}")]
    [HttpGet]
    public async Task<IActionResult> UpdateLocation(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7204/api/Locations/{id}");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<UpdateLocationDto>(jsonData);
        return View(values);

    }
    [Route("UpdateLocation/{id:int}")]
    [HttpPost]
    public async Task<IActionResult> UpdateLocation(UpdateLocationDto updateLocationDto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(updateLocationDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7204/api/Locations/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(updateLocationDto);

    }
}
