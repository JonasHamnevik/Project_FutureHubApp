using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FutureHub.Shared.Models;

public class Chat
{
    public int Id { get; set; }
    [Required]
    public string SenderID { get; set; }
    //[ForeignKey(nameof(SenderID))]
    public ApplicationUser? Sender { get; set; }
    public IEnumerable<ChatMessage>? Messages { get; set; }
}
