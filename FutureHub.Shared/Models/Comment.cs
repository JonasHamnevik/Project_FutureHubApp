namespace FutureHub.Shared.Models;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public string AuthorID { get; set; } = string.Empty;
    public User? Author { get; set; }
    public int PostID { get; set; }
    public Post? Post { get; set; }
}
