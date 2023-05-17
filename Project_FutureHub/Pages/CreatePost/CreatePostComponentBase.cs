using FutureHub.Core.Repositories.Contracts;
using FutureHub.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Project_FutureHub.Pages.CreatePost;

public class CreatePostComponentBase : ComponentBase
{
    [Inject]
    public IPostRepository _postRepo { get; set; } = null!;

    //[Parameter]
    //public EventCallback<string> OnPostCreated { get; set; }

    //public string Title { get; set; }
    //public string Content { get; set; }
    public User AuthUser { get; set; }

    public Post UserPost { get; set; } = new Post();

    public async Task CreatePost()
    {
        //await OnPostCreated.InvokeAsync(UserPost);
        
        await _postRepo.CreateAsync(UserPost);
    }
}
