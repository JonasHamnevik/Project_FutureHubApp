using FutureHub.Shared.Models;
using System.Threading.Tasks;

namespace FutureHub.Core.Repositories.Contracts;

public interface IPostRepository
{
    Task<IEnumerable<Post>> GetAllAsync();
    Task CreateAsync(Post post);
    //Task<Post> CreateAsync(Post post);
}
