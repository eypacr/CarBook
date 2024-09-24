﻿using CarBook.Application.Features.Mediator.Queries.AuthorQueries;
using CarBook.Application.Features.Mediator.Results.AuthorResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers
{
	public class GetBlogByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
	{
		private readonly IRepository<Author> _repository;

		public GetBlogByIdQueryHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetAuthorByIdQueryResult
			{
				AuthorId = values.AuthorId,
				Name = values.Name,
				Description = values.Description,
				ImageUrl = values.ImageUrl
			};
		}
	}

















}
