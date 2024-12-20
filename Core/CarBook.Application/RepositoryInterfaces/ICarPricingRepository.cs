using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface ICarPricingRepository
{
    List<CarPricing> GetCarPricingWithCars();
}
