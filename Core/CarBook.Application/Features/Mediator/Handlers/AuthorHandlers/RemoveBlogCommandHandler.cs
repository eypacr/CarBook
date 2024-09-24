﻿using CarBook.Application.Features.Mediator.Commands.AuthorCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.AuthorHandlers
{
	public class RemoveBlogCommandHandler : IRequestHandler<RemoveAuthorCommand>
	{
		private readonly IRepository<Author> _repository;

		public RemoveBlogCommandHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(value);
		}
	}













}
