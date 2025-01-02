using CarBook.WebUI.Dtos.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailsMainComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _BlogDetailsMainComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7204/api/Blogs/{id}");

        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<GetBlogByIdDto>(jsonData);

            // Eğer value null ise, uygun bir mesaj döndürmek için kontrol ekleyelim.
            if (value == null)
            {
                return Content("Blog bulunamadı.");
            }

            ViewBag.id = id;
            return View(value);
        }

        // API çağrısı başarısız olursa uygun bir hata mesajı döndürün
        return Content("Blog verisi alınırken bir hata oluştu.");
    }


}
