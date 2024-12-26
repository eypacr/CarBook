using CarBook.Application.Features.CQRS.Results.CategoryResults;
using MediatR;

namespace CarBook.Application.Features.CQRS.Queries.CategoryQueries;

public class GetCategoryWithBlogCountQuery : IRequest<GetCategoryWithBlogCountQueryResult>
{
    public int CategoryId { get; set; }
}
