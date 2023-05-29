using System.ComponentModel.DataAnnotations;

namespace FutureHub.Shared.Models;

public class Message
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }
}
