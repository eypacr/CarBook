namespace CarBook.WebUI.Dtos.AuthorDtos;

public class UpdateAuthorDto
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
