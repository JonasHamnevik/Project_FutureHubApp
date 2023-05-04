using Microsoft.AspNetCore.Identity;

namespace FutureHub.Shared.Models;

public class User
{
    public Guid Id { get; set; }
    [PersonalData]
    public string FirstName { get; set; } = string.Empty;
    [PersonalData]
    public string LastName { get; set; } = string.Empty;
    public string ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public UserRole Role { get; set; }

    //public List<Contact>? Contacts { get; set; }
    //public List<Chat>? Chats { get; set; }
}
