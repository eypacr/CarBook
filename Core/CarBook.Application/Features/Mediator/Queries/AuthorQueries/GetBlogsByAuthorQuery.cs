using CarBook.Application.Features.Mediator.Results.AuthorResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.AuthorQueries;

public class GetBlogsByAuthorQuery:IRequest<List<GetBlogsByAuthorQueryResult>>
{
    public int Id { get; set; }

    public GetBlogsByAuthorQuery(int id)
    {
        Id = id;
    }
}
