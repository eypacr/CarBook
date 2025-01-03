namespace CarBook.Application.RepositoryInterfaces;

public interface IStatisticRepository
{
    int GetCarCount();
    int GetLocationCount();
    int GetAuthorCount();
    int GetBlogCount();
    int GetBrandCount();
    decimal GetAvgRentPriceForDaily();
    decimal GetAvgRentPriceForWeekly();
    decimal GetAvgRentPriceForMonthly();
    int GetCarCountByTransmissionAuto();
    string GetBrandNameByMaxCar();
    string GetMostHaveCommentBlog();
    int GetCarCountByKmSmallerThen10000();
    int GetCarCountByFuelGasolineOrDiesel();
    int GetCarCountByFuelElectric();
    string GetCarBrandAndModelByMostExpensiveRentPriceDaily();
    string GetCarBrandAndModelByCheapestRentPriceDaily();

}
