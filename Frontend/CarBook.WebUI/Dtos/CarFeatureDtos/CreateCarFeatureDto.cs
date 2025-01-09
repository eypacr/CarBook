namespace CarBook.WebUI.Dtos.CarFeatureDtos;

public class CreateCarFeatureDto
{
    public int CarId { get; set; }
    public int FeatureId { get; set; }
    public bool Available { get; set; }
}
