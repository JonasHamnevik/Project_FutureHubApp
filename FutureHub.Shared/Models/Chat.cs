using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FutureHub.Shared.Models;

public class Chat
{
    public int Id { get; set; }
    [Required]
    public Guid SenderID { get; set; }
    [ForeignKey(nameof(SenderID))]
    public User? Sender { get; set; }
    public IEnumerable<ChatMessage>? Messages { get; set; }
}
