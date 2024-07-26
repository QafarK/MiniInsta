namespace MiniInsta.Models;

internal class PostTag
{
    public int Id { get; set; }
    public int IdPost { get; set; }
    public int IdTag { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} IdPost: {IdPost} IdTag: {IdTag}";
    }
}
