using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
[Route("Admin/[controller]")]
public class AdminDashboardController : Controller
{
    [Route("Index")]
    public IActionResult Index()
    {
        return View();
    }
}
