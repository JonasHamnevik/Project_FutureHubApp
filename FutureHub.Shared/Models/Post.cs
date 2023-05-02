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
    public string AuthorID { get; set; } = string.Empty;
    [Required]
    public User? Author { get; set; }
}
