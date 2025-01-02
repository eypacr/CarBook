namespace CarBook.WebUI.Dtos.ContactDtos;

public class ContactListDto
{
    public int ContactId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public DateTime SendingDate { get; set; }
}
