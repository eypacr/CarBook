namespace CarBook.Domain.Entities;

public class ReservationStatus
{
    public int ReservationStatusId { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public List<Reservation> Reservations { get; set; }
}