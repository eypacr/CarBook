using CarBook.WebUI.Dtos.FooterAddressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents;

public class _UILayoutFooterComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _UILayoutFooterComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/FooterAddresses");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);
            ViewBag.description = value.Select(x => x.Description).FirstOrDefault();
            return View(value);
        }
        return View();
    }
}
