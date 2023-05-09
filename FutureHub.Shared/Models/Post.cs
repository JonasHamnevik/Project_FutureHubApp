using System.ComponentModel.DataAnnotations;

namespace FutureHub.Shared.Models;

public class Post
{
    public Guid Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Content { get; set; } = string.Empty;
    [Required]
    public Guid AuthorId { get; set; }
    public User? Author { get; set; }
}
