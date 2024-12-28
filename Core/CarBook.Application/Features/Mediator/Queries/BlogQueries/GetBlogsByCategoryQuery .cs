using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries;

public class GetBlogsByCategoryQuery : IRequest<List<GetBlogsByCategoryQueryResult>>
{
    public int Id { get; set; }

    public GetBlogsByCategoryQuery(int id)
    {
        Id = id;
    }
}
