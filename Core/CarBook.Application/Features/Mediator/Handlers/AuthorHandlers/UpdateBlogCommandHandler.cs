﻿using CarBook.Application.Features.Mediator.Commands.AuthorCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers
{
	public class UpdateBlogCommandHandler : IRequestHandler<UpdateAuthorCommand>
	{
		private readonly IRepository<Author> _repository;

		public UpdateBlogCommandHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.AuthorId);
			values.Name = request.Name;
			values.Description = request.Description;
			values.ImageUrl = request.ImageUrl;
			await _repository.UpdateAsync(values);
		}
	}











}
