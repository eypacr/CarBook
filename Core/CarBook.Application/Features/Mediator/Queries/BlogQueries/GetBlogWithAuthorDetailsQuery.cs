using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries;

public class GetBlogWithAuthorDetailsQuery:IRequest<List<GetBlogWithAuthorDetailsQueryResult>>
{
    public int Id { get; set; }

    public GetBlogWithAuthorDetailsQuery(int id)
    {
        Id = id;
    }
}