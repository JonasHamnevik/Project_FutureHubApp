using FutureHub.Core.Data;
using FutureHub.Core.Repositories.Contracts;
using FutureHub.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FutureHub.Core.Repositories;

public class PostRepository : IPostRepository
{
    private readonly ApplicationDbContext _context;

    public PostRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Post post)
    {
        _context.Posts.Add(post);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Post>> GetAllAsync()
    {
        return await _context.Posts
            .ToListAsync();
    }

    //public async Task<Post> CreateAsync(Post post)
    //{
    //    _context.Posts.Add(post);
    //    await _context.SaveChangesAsync();
    //    return post;
    //}
}
