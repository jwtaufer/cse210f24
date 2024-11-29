public class Comment
{
    private string _commentAuthor;
    private string _commentText;

    public Comment(string author, string text)
    {
        _commentAuthor = author;
        _commentText = text;
    }

    public string ReturnComment()
    {
        return $"{_commentAuthor}: \n{_commentText}";
    }
}