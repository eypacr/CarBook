using CarBook.Application.RepositoryInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories;

public class ReservationRepository : IReservationRepository
{
    private readonly CarBookContext _context;

    public ReservationRepository(CarBookContext context)
    {
        _context = context;
    }

    public List<Reservation> GetReservationListWithAllInfo()
    {
        var values = _context.Reservations.Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.PickUpLocation).Include(x => x.DropOffLocation).Include(x => x.ReservationStatus).ToList();
        return values;
    }
    public Reservation GetReservationById(int id)
    {
        var values = _context.Reservations.Where(x => x.ReservationId == id).Include(x => x.ReservationStatus).Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.PickUpLocation).Include(x => x.DropOffLocation).FirstOrDefault();
        return values;
    }
}