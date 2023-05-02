namespace FutureHub.Shared.Models;

public class User
{
    public Guid ID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public UserRole Role { get; set; }

    public List<Contact>? Contacts { get; set; }
    public List<Chat>? Chats { get; set; }
}
