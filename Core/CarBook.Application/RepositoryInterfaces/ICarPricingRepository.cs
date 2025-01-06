using CarBook.Application.Models;
using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface ICarPricingRepository
{
    List<CarPricing> GetCarPricingWithCars();
    public List<CarPricingViewModel> GetCarPricingWithTimePeriod();
}
