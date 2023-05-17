using FutureHub.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FutureHub.Core.Data;

public interface IApplicationDbContext
{
    DbSet<Comment> Comments { get; }
    DbSet<Post> Posts { get; }
    DbSet<Chat> Chats { get; }
    DbSet<ChatMessage> ChatMessages { get; }
    //DbSet<User> Users { get; }
}
