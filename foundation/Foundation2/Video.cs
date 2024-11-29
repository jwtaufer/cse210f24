using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLengthPerSecond;
    private List<Comment> _comments;

    public Video(string title, string author, int videoLengthPerSecond)
    {
        _title = title;
        _author = author;
        _videoLengthPerSecond = videoLengthPerSecond;
        _comments = new List<Comment>();
    }

    public void AddComment(string commentAuthor, string commentText)
    {
        Comment comment = new Comment(commentAuthor, commentText);
        _comments.Add(comment);
    }

    private int CountComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} ({_videoLengthPerSecond} seconds)");
        Console.WriteLine($"by {_author}");
        Console.WriteLine($"{CountComments()} comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.ReturnComment()}");
        }
        Console.WriteLine();
    }
}