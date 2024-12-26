using CarBook.WebUI.Dtos.TagCloudsDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailTagComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _BlogDetailTagComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7204/api/TagClouds/Blog/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<List<GetByBlogIdTagCloudDto>>(jsonData);
            ViewBag.id = id;
            return View(value);
        }
        return View();
    }
}