using CarBook.WebUI.Dtos.SocialMediaDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers;


[Area("Admin")]
[Route("Admin/[controller]")]
public class AdminSocialMediaController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AdminSocialMediaController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Route("Index")]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/SocialMedias/");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultSocialMediaDto>>(jsonData);
            return View(values);
        }
        return View();
    }

    [Route("DeleteSocialMedia/{id:int}")]
    public async Task<IActionResult> DeleteSocialMedia(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7204/api/SocialMedias?id={id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return RedirectToAction("Index");
    }


    [Route("CreateSocialMedia")]
    [HttpGet]
    public IActionResult CreateSocialMedia()
    {
        return View();

    }
    [Route("CreateSocialMedia")]
    [HttpPost]
    public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
        var responseMessage = await client.PostAsync("https://localhost:7204/api/SocialMedias", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);
    }

    [Route("UpdateSocialMedia/{id:int}")]
    [HttpGet]
    public async Task<IActionResult> UpdateSocialMedia(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7204/api/SocialMedias/{id}");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<UpdateSocialMediaDto>(jsonData);

        return View(values);

    }
    [Route("UpdateSocialMedia/{id:int}")]
    [HttpPost]
    public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7204/api/SocialMedias/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);

    }
}