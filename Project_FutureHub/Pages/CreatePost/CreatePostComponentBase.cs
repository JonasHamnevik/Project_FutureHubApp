using FutureHub.Core.Repositories.Contracts;
using FutureHub.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Project_FutureHub.Pages.CreatePost;

public class CreatePostComponentBase : ComponentBase
{
    [Inject]
    private IRepository<Post> _repository { get; set; }
    [Inject]
    private NavigationManager NavManager { get; set; }

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private ApplicationUser Author { get; set; }
    private string AuthUser { get; set; } = null!;

    public Post UserPost { get; set; } = new Post();

    //protected override async Task OnInitializedAsync()
    //{
    //    var authState = await authenticationStateTask;
    //    var user = authState.User;
    //    AuthUser = user.FindFirstValue(ClaimTypes.NameIdentifier);

    //}
    public async Task CreatePost()
    {
        //Here we check if logged in user is validated and get the Id of the user to save it on det post
        var authState = await authenticationStateTask;
        var user = authState.User;
        AuthUser = user.FindFirstValue(ClaimTypes.NameIdentifier);

        var post = Post.Create(Guid.NewGuid(), UserPost.Title, UserPost.Content, AuthUser, Author);
        await _repository.AddAsync(post);

        StateHasChanged();
        NavManager.NavigateTo("/Wall");
    }
}
