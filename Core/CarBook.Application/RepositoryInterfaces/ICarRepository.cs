using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface ICarRepository
{
    List<Car> GetCarsListWithBrands();
    List<Car> GetLast5CarsWithBrands();
    List<Car> GetCarsByBrand(int id);
    public Car GetCarById(int id);
}
