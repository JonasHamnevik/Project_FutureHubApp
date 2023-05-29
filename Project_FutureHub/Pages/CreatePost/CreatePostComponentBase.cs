﻿using FutureHub.Core.Repositories.Contracts;
using FutureHub.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Project_FutureHub.Pages.CreatePost;

public class CreatePostComponentBase : ComponentBase
{
    [Inject]
    public IPostRepository _postRepo { get; set; } = null!;

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }


    public ApplicationUser Author { get; set; }
    public string AuthUser { get; set; } = null!;
    public Post UserPost { get; set; } = new Post();

    //protected override async Task OnInitializedAsync()
    //{
    //    var authState = await authenticationStateTask;
    //    var user = authState.User;
    //    AuthUser = user.FindFirstValue(ClaimTypes.NameIdentifier);

    //}
    public async Task CreatePost()
    {
        var authState = await authenticationStateTask;
        var user = authState.User;
        AuthUser = user.FindFirstValue(ClaimTypes.NameIdentifier);

        var post = Post.Create(Guid.NewGuid(), UserPost.Title, UserPost.Content, AuthUser, Author);
        await _postRepo.CreateAsync(post);
        StateHasChanged();

        await _postRepo.GetAllAsync();
    }
}
