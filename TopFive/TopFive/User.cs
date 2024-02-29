namespace TopFive;

public class User
{
    // Variables
    public string Name { get; private set; }
    public string Username { get; private set; }
    public string Email { get; private set; }

    public List<Friend> FriendList { get; private set; }
    public List<Uri> ExternalLinks { get; private set; }
    private bool Visibility { get; set; }
    private Role Role { get; set; }
    private string Password { get; set; }
    // Constructor

    public User(string name = "", string username = "", string email = "", bool visibility = false, string password = "")
    {
        Name = name;
        Username = username;
        Email = email;
        FriendList = new List<Friend>();
        ExternalLinks = new List<Uri>();
        Visibility = visibility;
        Role = new Role();
        Password = password;
    }
}