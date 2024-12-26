namespace CarBook.WebUI.Dtos.BlogDtos;

public class GetBlogByIdDto
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int AuthorID { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }
}
