class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = [];


    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;

        foreach(Comment comment in comments)
        {
            _comments.Add(comment);
        }

    }


    public void DisplayVideoInfo()
    {
        Console.WriteLine("Video info: ");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"number of comments: {GetCommentCount()}");
        Console.WriteLine($"Comments: ");
        
        foreach(Comment comment in _comments)
        {
            Console.WriteLine(comment.DisplayComment());
            
            
        }

        
    }


    public int GetCommentCount()
    {
        return _comments.Count();
    }


}