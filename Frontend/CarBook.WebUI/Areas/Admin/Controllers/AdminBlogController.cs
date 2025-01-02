using CarBook.WebUI.Dtos.AuthorDtos;
using CarBook.WebUI.Dtos.BlogDtos;
using CarBook.WebUI.Dtos.CategorysDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers;
[Area("Admin")]
[Route("Admin/AdminBlog")]
public class AdminBlogController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;
    public AdminBlogController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    [Route("Index")]
    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7204/api/Blogs/GetAllBlogsWithAuthorsList");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultAllBlogsWithAuthorsDto>>(jsonData);
            return View(values);
        }
        return View();
    }

    [Route("RemoveBlog/{id}")]
    public async Task<IActionResult> RemoveBlog(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync("https://localhost:7204/api/Blogs?id=" + id);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index", "AdminBlog", new { area = "Admin" });
        }
        return View();
    }

    [HttpGet]
    [Route("CreateBlog")]
    public async Task<IActionResult> CreateBlog()
    {
        var client = _httpClientFactory.CreateClient();

        var authorsResponse = await client.GetAsync("https://localhost:7204/api/Authors");
        var categoriesResponse = await client.GetAsync("https://localhost:7204/api/Categories");

        if (authorsResponse.IsSuccessStatusCode && categoriesResponse.IsSuccessStatusCode)
        {
            var authorsJsonData = await authorsResponse.Content.ReadAsStringAsync();
            var categoriesJsonData = await categoriesResponse.Content.ReadAsStringAsync();

            var authorValues = JsonConvert.DeserializeObject<List<ResultAuthorDto>>(authorsJsonData);
            var categoryValues = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(categoriesJsonData);

            ViewBag.AuthorValues = authorValues.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.AuthorId.ToString()
            }).ToList();

            ViewBag.CategoryValues = categoryValues.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.CategoryId.ToString()
            }).ToList();

            return View();
        }

        return View();
    }

    [HttpPost]
    [Route("CreateBlog")]
    public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
    {
        if (createBlogDto == null)
        {
            return BadRequest("Blog verileri alınamadı");
        }

        createBlogDto.CreatedDate = DateTime.Now; // Set current date as the created date
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createBlogDto);
        var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

        var responseMessage = await client.PostAsync("https://localhost:7204/api/Blogs", stringContent);

        // Yanıt içeriğini al
        var responseContent = await responseMessage.Content.ReadAsStringAsync();

        // Yanıtı konsola yazdır
        Console.WriteLine(responseContent);

        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index", "AdminBlog", new { area = "Admin" });
        }

        // 500 hatası aldığınızda, responseContent size hatanın detaylarını verebilir
        return View();
    }

}
