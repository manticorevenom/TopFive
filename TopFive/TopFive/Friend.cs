namespace TopFive;

public class Friend : User
{
    private Chat Chat { get; set; }

    public Friend()
    {
        Chat = new Chat();
    }
}