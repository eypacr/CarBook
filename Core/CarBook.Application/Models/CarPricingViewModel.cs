namespace CarBook.Application.Models;

public class CarPricingViewModel
{
    public CarPricingViewModel()
    {
        Amounts = new List<decimal>();
    }
    public string Model { get; set; }
    public List<decimal> Amounts { get; set; }
    public string CoverImageUrl { get; set; }
    public string Brand { get; set; }

}
