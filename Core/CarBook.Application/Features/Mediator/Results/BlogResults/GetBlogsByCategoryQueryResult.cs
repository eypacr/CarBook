namespace CarBook.Application.Features.Mediator.Results.BlogResults;

public class GetBlogsByCategoryQueryResult
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string CoverImageUrl { get; set; }
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string AuthorImageUrl { get; set; }
}
