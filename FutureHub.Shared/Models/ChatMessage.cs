using System.ComponentModel.DataAnnotations.Schema;

namespace FutureHub.Shared.Models;

public class ChatMessage
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }
}
