namespace FutureHub.Shared.Models;

public class Chat
{
    public int Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public int SenderID { get; set; }
    public User? Sender { get; set; }
    public int RecieverID { get; set; }
    public User? Reciever { get; set; }
    public List<ChatMessage>? ChatMessages { get; set; }
}
