namespace FutureHub.Shared.Models;

public class Message
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }
    public string? SenderId { get; set; }
    public virtual ApplicationUser? Sender { get; set; }
    public string? RecieverId { get; set; }
    public virtual ApplicationUser? Reciever { get; set; }

}
