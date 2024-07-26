namespace MiniInsta.Models;

internal class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Pswd { get; set; }
    public bool IsOpen { get; set; }
    public bool Gender { get; set; }
    public DateTime Birthday { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} Login: {Login} Password: {Pswd} IsOpen: {IsOpen} Gender: {Gender} Birthday: {Birthday.ToShortDateString()}";
    }
}
