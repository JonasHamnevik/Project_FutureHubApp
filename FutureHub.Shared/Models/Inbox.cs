using System.ComponentModel.DataAnnotations;

namespace FutureHub.Shared.Models;

public class Inbox
{
    public int Id { get; set; }
    public ApplicationUser? Sender { get; set; }
    public ApplicationUser? Reciever { get; set; }
    public List<Message>? Messages { get; set; }
}
