namespace CarBook.WebUI.Dtos.AuthorDtos;

public class GetBlogsByAuthorDto
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
}
