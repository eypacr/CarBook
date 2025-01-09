using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories;

public class CarFeatureRepository : ICarFeatureRepository
{
    private readonly CarBookContext _context;

    public CarFeatureRepository(CarBookContext context)
    {
        _context = context;
    }

    public void ChangeCarFeatureAvaiableToFalse(int id)
    {
        var values = _context.CarFeatures.Where(x => x.CarFeatureId == id).FirstOrDefault();
        values.Available = false;
        _context.SaveChanges();
    }

    public void ChangeCarFeatureAvaiableToTrue(int id)
    {
        var values = _context.CarFeatures.Where(x => x.CarFeatureId == id).FirstOrDefault();
        values.Available = true;
        _context.SaveChanges();
    }

    public void CreateCarFeatureByCarId(CarFeature carFeature)
    {
        _context.CarFeatures.Add(carFeature);
        _context.SaveChanges();
    }

    public List<CarFeature> GetCarFeatureListByCarId(int id)
    {
        var values = _context.CarFeatures.Where(x => x.CarId == id).Include(x => x.Feature).Include(x => x.Car).ToList();
        return values;
    }

    public async Task<CarFeature> GetFeatureWithAllInfoById(int id)
    {
        return await _context.CarFeatures
            .Include(x => x.Feature)
            .Include(x => x.Car)     
            .FirstOrDefaultAsync(x => x.CarFeatureId == id);
    }

}
