﻿using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
	public class GetCarPricingWithCarQueryHandler : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
	{
		public readonly ICarPricingRepository _repository;

		public GetCarPricingWithCarQueryHandler(ICarPricingRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
		{
			var values = _repository.GetCarPricingWithCars();
			return values.Select(x => new GetCarPricingWithCarQueryResult
			{
				CarId = x.CarId,
				CarPricingId = x.CarPricingId,
				Brand = x.Car.Brand.Name,
				Model = x.Car.Model,
				Amount = x.Amount,
				CoverImageUrl = x.Car.CoverImageUrl
			}).ToList();
		}
	}
}
