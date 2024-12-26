using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents;

public class _BlogDetailsParagraphComponentPatial:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
