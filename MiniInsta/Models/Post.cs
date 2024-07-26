namespace MiniInsta.Models;

internal class Post
{
    public int Id { get; set; }
    public int IdUser { get; set; }
    public DateTime Date { get; set; }
    public string? Text { get; set; }
    public string ImagePath { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} IdUser: {IdUser} Date: {Date.ToShortDateString()} Text: {Text} ImagePath: {ImagePath}";
    }
}

