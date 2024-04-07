using System.Security.AccessControl;
using System.Transactions;

class Video
{
    public string Title;
    public  string Author;
    public  int Length;

    public  List<Comment> Comments{get;set;}

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }



    public int GetCommentCount() => Comments.Count;

    public void AddComment(string commenter, string text) => Comments.Add(new Comment(commenter, text));


}