using MiniInsta.DataBase;
using MiniInsta.Models;

Console.WriteLine("Hello, World!");

using (InstaContext db = new InstaContext())
{
    User user = new User()
    {
        Login = "User1",
        Pswd = "pasword123",
        IsOpen = true,
        Gender = true,
        Birthday = new(2010, 10, 11)
    };

    Post post = new Post()
    {
        IdUser = 1,
        Date = DateTime.Now,
        Text = "Test",
        ImagePath = "",
    };
    PostTag postTag = new PostTag()
    {
        IdPost = 1,
        IdTag = 1
    };
    Tag tag = new Tag()
    {
         Tag_="tag1"
    };

    db.Users.Add(user);
    db.Posts.Add(post);
    db.PostTags.Add(postTag);
    db.Tags.Add(tag);
    db.SaveChanges();
}