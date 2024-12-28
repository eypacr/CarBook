namespace CarBook.WebUI.Dtos.CategorysDtos;

public class GetShowBlogsByCategoryDto
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string CoverImageUrl { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string AuthorImageUrl { get; set; }
}
