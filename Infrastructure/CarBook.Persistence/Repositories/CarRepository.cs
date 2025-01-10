using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public Car GetCarById(int id)
        {
            var values = _context.Cars
                .Include(c => c.Brand)
                .Include(c => c.RentACarProcesses) 
                .Include(c => c.CarDescriptions)
                .Include(c => c.RentACars)
                .FirstOrDefault(c => c.CarId == id);

            return values;
        }



        public List<Car> GetCarsByBrand(int id)
        {
            var values = _context.Cars
                .Include(x => x.Brand)
                .Where(x => x.BrandId == id)
                .ToList();
            return values;
        }

        public List<Car> GetCarsListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }

        public List<Car> GetLast5CarsWithBrands()
        {
            var values = _context.Cars
               .Include(x => x.Brand)
               .OrderByDescending(x => x.CarId)
               .Take(5)
               .ToList();

            return values;
        }
    }
}
