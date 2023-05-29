using System.ComponentModel.DataAnnotations;

namespace FutureHub.Shared.Models;

public class Post
{
    public Guid Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    [Required]
    public string Content { get; set; } = string.Empty;
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public string? AuthorId { get; set; }
    public ApplicationUser? Author { get; set; }

    public Post() { }

    public static Post Create(Guid id, string title, string content, string authorId, ApplicationUser author)
    {
        var post = new Post()
        {
            Id = id,
            Title = title,
            Content = content,
            AuthorId = authorId,
            Created = DateTime.Now,
            Author = author
        };
        return post;
    }
    //public static Post Update(string title, string content) 
    //{
    //    var post = new Post()
    //    {
    //        Title = title,
    //        Content = content,
    //        Updated = DateTime.Now
    //    };
    //    return post;
    //}
}
