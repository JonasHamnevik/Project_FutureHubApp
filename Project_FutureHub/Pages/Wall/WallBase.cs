using FutureHub.Core.Repositories.Contracts;
using FutureHub.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Project_FutureHub.Pages.Wall;

public class WallBase: ComponentBase
{
    [Inject]
    public IRepository<Post>? _repository { get; set; }
    //public IRepository<Post>? _repository { get; set; }

    public IEnumerable<Post>? Posts { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Posts = await _repository.GetAllAsync();
        StateHasChanged();
    }
}
