namespace CarBook.Application.Features.Mediator.Results.AuthorResults;

public class GetBlogsByAuthorQueryResult
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string CoverImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
}
