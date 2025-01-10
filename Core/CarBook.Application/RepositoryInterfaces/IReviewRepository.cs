using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface IReviewRepository
{
    public List<Review> GetReviewListByCarId(int id);
}
