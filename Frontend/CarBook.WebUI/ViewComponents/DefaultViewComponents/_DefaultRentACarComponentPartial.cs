using CarBook.WebUI.Dtos.LocationDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.DefaultViewComponents;

public class _DefaultRentACarComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _DefaultRentACarComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/Locations");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
            List<SelectListItem> list = (from x in values
                                         select new SelectListItem
                                         {
                                             Text = x.Name,
                                             Value = x.LocationId.ToString(),
                                         }).ToList();
            ViewBag.locationList = list;
        }
        return View();
    }
}