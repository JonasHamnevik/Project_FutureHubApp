using System.ComponentModel.DataAnnotations;

namespace FutureHub.Shared.Models;

public class Post
{
    public Guid Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Content { get; set; } = string.Empty;
   
    public string? AuthorId { get; set; }
    public ApplicationUser? Author { get; set; }

    public Post()  { }

    public static Post Create(Guid id, string title, string content, string authorId, ApplicationUser author) /*, ApplicationUser author*/
    {
        var post = new Post() 
        { 
            Id = id, 
            Title = title, 
            Content = content, 
            AuthorId = authorId,
            Author = author
        };
        return post;
    }
}
