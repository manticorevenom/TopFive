namespace TopFive;

public class Community
{
    // Variables
    public int Members { get; private set; }
    public string Id { get; private set; }
    private bool Visibility { get; set; }
    public List<Post> Posts { get; private set; }
    public List<User> Users { get; private set; }
    // Methods
    public void AddPost(Post post)
    {
        if (!Posts.Contains(post))
        {
            Posts.Add(post);
        }
        else
        {
            Console.WriteLine("Post already exists.");
        }
    }

    public void DeletePost(Post post)
    {
        if (!Posts.Contains(post))
        {
            Console.WriteLine("Post does not exist.");
        }
        else
        {
            Posts.Remove(post);
        }
    }
    // Constructor

    public Community(string id = "", bool visibility = false)
    {
        Members = 0;
        Id = id;
        Visibility = visibility;
        Posts = new List<Post>();
        Users = new List<User>();
    }
}