namespace Project_FutureHub.Shared.Models;

public class Contact
{
    public int Id { get; set; }
    public string UserID { get; set; } = string.Empty;
    public User? User { get; set; }
    public string ContactID { get; set; } = string.Empty;
    public User? UserContact { get; set; }
}
