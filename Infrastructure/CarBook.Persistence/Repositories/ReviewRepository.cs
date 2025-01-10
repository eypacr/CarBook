using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories;

public class ReviewRepository : IReviewRepository
{
    private readonly CarBookContext _context;

    public ReviewRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<Review> GetReviewListByCarId(int id)
    {
        var values = _context.Reviews.Where(x => x.CarId == id).Include(x => x.Car).ToList();
        return values;
    }
}
