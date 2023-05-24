using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FutureHub.Shared.Models;

public class Message
{
    public int Id { get; set; }
    [Required]
    public string SenderID { get; set; }
    [Required]
    public string RecieverID { get; set; }
    [Required]
    public string Content { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }

    public Message() { }

    public static Message Create(int id, string senderId, string recieverId, string content, DateTime sentAt)
    {
        var message = new Message()
        {
            Id = id,
            SenderID = senderId,
            RecieverID = recieverId,
            Content = content,
            SentAt = sentAt
        };
        return message;
    }
}
