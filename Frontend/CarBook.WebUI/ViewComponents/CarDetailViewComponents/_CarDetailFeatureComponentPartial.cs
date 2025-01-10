using CarBook.WebUI.Dtos.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.CarDetailViewComponents;

public class _CarDetailFeatureComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _CarDetailFeatureComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7204/api/Cars/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<CarListDto>(jsonData);
            ViewBag.id = id;
            return View(value);
        }
        return View();
    }
}
