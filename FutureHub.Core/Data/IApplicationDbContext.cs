using FutureHub.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FutureHub.Core.Data;

public interface IApplicationDbContext
{
    //DbSet<Chat> Chats { get; }
    DbSet<Comment> Comments { get; }
    //DbSet<ChatMessage> ChatMessages { get; }
    //DbSet<Contact> Contacts { get; }
    DbSet<Post> Posts { get; }
    DbSet<User> Users { get; }
}
