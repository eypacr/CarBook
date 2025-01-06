using CarBook.Domain.Entities;

namespace CarBook.Application.RepositoryInterfaces;

public interface IReservationRepository
{
    public List<Reservation> GetReservationListWithAllInfo();
    public Reservation GetReservationById(int id);
}