namespace TopFive;

public class Post
{
    // Variables
    public string Id { get; private set; }
    public string Info { get; private set; }
    public int Likes { get; private set; }
    public int Dislikes { get; private set; }
    // Methods
    public void Like()
    {
        Likes++;
    }

    public void Dislike()
    {
        Dislikes++;
    }

    public void Update(string info)
    {
        Info = info;
    }
    // Constructor
    public Post(string id = "", string info = "")
    {
        Id = id;
        Info = info;
        Likes = 0;
        Dislikes = 0;
    }
}