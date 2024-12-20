using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface ICarRepository
{
    List<Car> GetCarsListWithBrands();
    List<Car> GetLast5CarsWithBrands();
}
