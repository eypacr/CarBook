using CarBook.WebUI.Dtos.CommentDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CommentViewComponents;

public class _AddCommentComponentPartial:ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;

    public _AddCommentComponentPartial(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IViewComponentResult> InvokeAsync(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7204/api/Blogs/AuthorDetails/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            CommentCreateDto commentCreateDto = new CommentCreateDto();
            commentCreateDto.BlogId = id;
            return View(commentCreateDto);
        }
        return View();
    }
}
