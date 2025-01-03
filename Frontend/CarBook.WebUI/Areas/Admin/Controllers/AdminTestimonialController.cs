using CarBook.WebUI.Dtos.TestimonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]")]
public class AdminTestimonialController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AdminTestimonialController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Route("Index")]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/Testimonials/");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
            return View(values);
        }
        return View();
    }

    [Route("DeleteTestimonial/{id:int}")]
    public async Task<IActionResult> DeleteTestimonial(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7204/api/Testimonials?id={id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return RedirectToAction("Index");
    }


    [Route("CreateTestimonial")]
    [HttpGet]
    public IActionResult CreateTestimonial()
    {
        return View();

    }
    [Route("CreateTestimonial")]
    [HttpPost]
    public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
        var responseMessage = await client.PostAsync("https://localhost:7204/api/Testimonials", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);
    }

    [Route("UpdateTestimonial/{id:int}")]
    [HttpGet]
    public async Task<IActionResult> UpdateTestimonial(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7204/api/Testimonials/{id}");
        var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<UpdateTestimonialDto>(jsonData);

        return View(values);

    }
    [Route("UpdateTestimonial/{id:int}")]
    [HttpPost]
    public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto dto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(dto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7204/api/Testimonials/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View(dto);

    }
}
