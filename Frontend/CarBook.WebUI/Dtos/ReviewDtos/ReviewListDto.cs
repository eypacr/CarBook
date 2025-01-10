namespace CarBook.WebUI.Dtos.ReviewDtos;

public class ReviewListDto
{
    public int reviewId { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public string email { get; set; }
    public string text { get; set; }
    public string imageUrl { get; set; }
    public DateTime createdDate { get; set; }
    public bool isApproved { get; set; }
    public int carId { get; set; }

}
