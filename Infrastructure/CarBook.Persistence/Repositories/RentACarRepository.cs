using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarBook.Persistence.Repositories;

public class RentACarRepository : IRentACarRepository
{
    private readonly CarBookContext _context;

    public RentACarRepository(CarBookContext context)
    {
        _context = context;
    }

    public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
    {
        var values = await _context.RentACars.Where(filter).Include(x => x.Car).ThenInclude(x => x.CarPricings).Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.Location).ToListAsync(); //Burada filtrerdan gelen şart sorgu olarak gönderiliyor.
        return values;
    }
}