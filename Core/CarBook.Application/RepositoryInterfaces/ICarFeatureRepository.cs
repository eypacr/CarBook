using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface ICarFeatureRepository
{
    public List<CarFeature> GetCarFeatureListByCarId(int id);
    void ChangeCarFeatureAvaiableToFalse(int id);
    void ChangeCarFeatureAvaiableToTrue(int id);
    void CreateCarFeatureByCarId(CarFeature carFeature);
    Task<CarFeature> GetFeatureWithAllInfoById(int id);
}
