using CarBook.WebUI.Dtos.CategorysDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailSideBarCategoriesComponentPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _BlogDetailSideBarCategoriesComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/Categories");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
            return View(value);
        }
        return View();
    }
}
