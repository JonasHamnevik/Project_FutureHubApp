﻿namespace Project_FutureHub.Shared.Models;

public class ChatMessage
{
    public int ID { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime SentAt { get; set; }
    public string SenderID { get; set; } = string.Empty;
    public User? Sender { get; set; }
    public int ChatID { get; set; }
    public Chat? Chat { get; set; }
}