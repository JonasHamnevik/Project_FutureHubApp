using FutureHub.Core.Repositories.Contracts;
using FutureHub.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Project_FutureHub.Pages.Chat;

public class ChatComponentBase : ComponentBase
{
    [Inject]
    public IRepository<Message>? Repository { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    public string User { get; set; }

    public async Task Send(string content, string reciever)
    {
        var authState = await authenticationStateTask;
        var user = authState.User;
        User = user.FindFirstValue(ClaimTypes.NameIdentifier);

        var message = new Message()
        {
            Content = content,
            SentAt = DateTime.UtcNow,
            SenderId = User,
            RecieverId = reciever
        };

        await Repository.AddAsync(message);
    }
}
