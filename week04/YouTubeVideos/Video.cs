using System.Numerics;

public class Video{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;

        _comments = new List<Comment>();
    }

    public void AddComment (Comment comment){
        _comments.Add(comment);
    }

    public int GetCommentNumber(){
        int total = _comments.Count;
        return total;
    }

    public string GetDisplayText(){
        string details = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nComments: {GetCommentNumber()}\n\n";

        foreach (Comment comment in _comments){
            details += $"{comment.GetComment()}\n\n";
        }

        return details.ToString();
    }
}
