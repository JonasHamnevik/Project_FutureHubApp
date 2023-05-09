namespace FutureHub.Shared.Models;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public Guid AuthorId { get; set; }
    public User? Author { get; set; }
    public Guid? PostId { get; set; }
    public Post? Post { get; set; }
}
