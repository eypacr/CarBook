namespace CarBook.WebUI.Dtos.ReviewDtos;

public class ReviewCreateDto
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Text { get; set; }
    public string ImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsApproved { get; set; }
    public int CarId { get; set; }
}
