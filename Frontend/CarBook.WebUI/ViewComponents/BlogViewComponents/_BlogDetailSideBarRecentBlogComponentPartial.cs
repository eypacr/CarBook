using CarBook.WebUI.Dtos.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailSideBarRecentBlogComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _BlogDetailSideBarRecentBlogComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/Blogs/GetLast3BlogsWithAuthorsList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<List<ResultLast3BlogsWithAuthorsDto>>(jsonData);
            return View(value);
        }
        return View();
    }
}
