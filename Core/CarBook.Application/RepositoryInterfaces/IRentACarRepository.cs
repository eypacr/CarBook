using CarBook.Domain.Entities;
using System.Linq.Expressions;

namespace CarBook.Application.RepositoryInterfaces;

public interface IRentACarRepository
{
    Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter); //bool= geriye dönecek olan durumu belirtecek, filter= gönderilecek olan şart.
}