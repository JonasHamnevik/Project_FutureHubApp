using FutureHub.Core.Repositories.Contracts;
using FutureHub.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Project_FutureHub.Pages.Wall;

public class WallBase: ComponentBase
{
    //[Inject]
    //public IPostRepository? _postRepository { get; set; }
    //public IRepository<Post>? _repository { get; set; }

    //Just tested with an seperate Repo for post(Becasue I forgot how to fetch everything from the
    // db XD)

    //[CascadingParameter]
    //public User AuthUser { get; set; }


    //public IEnumerable<Post> Posts { get; set; }

    //protected override async Task OnInitializedAsync()
    //{
    //    Posts = await _postRepository.GetAllAsync();
    //    StateHasChanged();
    //}
}
