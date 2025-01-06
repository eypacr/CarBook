namespace CarBook.WebUI.Dtos.CarPricingsDtos;

public class CarPricingListDto
{
    public string brand { get; set; }
    public string model { get; set; }
    public string coverImageUrl { get; set; }
    public decimal dailyAmount { get; set; }
    public decimal weeklyAmount { get; set; }
    public decimal monthlyAmount { get; set; }
}