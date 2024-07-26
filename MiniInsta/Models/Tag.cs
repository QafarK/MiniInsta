namespace MiniInsta.Models;

internal class Tag
{
    public int Id { get; set; }
    public string Tag_ { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} Tag: {Tag_}";
    }
}
