namespace CarBook.WebUI.Dtos.CarFeatureDtos;

public class CarFeatureListByCarIdDto
{
    public int carFeatureId { get; set; }
    public int carId { get; set; }
    public int featureId { get; set; }
    public string featureName { get; set; }
    public bool available { get; set; }
}
