using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailSideBarSearchBoxComponentPartial : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _BlogDetailSideBarSearchBoxComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }
}
