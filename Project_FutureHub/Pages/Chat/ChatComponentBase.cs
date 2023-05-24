using FutureHub.Core.Repositories.Contracts;
using FutureHub.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Project_FutureHub.Pages.Chat;

public class ChatComponentBase : ComponentBase
{
    [Inject]
    public IRepository<Message> Repository { get; set; }

}
