using JetBrains.Annotations;
using TopFive;
using Xunit;

namespace TopFive.Tests;
public class UserTests
{
    [Fact]
    public void Constructor_Initializes_With_Default_Values()
    {
        // Arrange & Act
        var user = new User();

        // Assert
        Assert.Equal("", user.Name);
        Assert.Equal("", user.Username);
        Assert.Equal("", user.Email);
        Assert.Empty(user.FriendList);
        Assert.Empty(user.ExternalLinks);
        // Assert.False(user.Visibility);
        // Assert.NotNull(user.Role);
        // Assert.Equal("", user.Password);
    }

    [Fact]
    public void Constructor_Initializes_With_Given_Values()
    {
        // Arrange
        string name = "John Doe";
        string username = "johndoe123";
        string email = "johndoe@example.com";
        bool visibility = true;
        string password = "password123";

        // Act
        var user = new User(name, username, email, visibility, password);

        // Assert
        Assert.Equal(name, user.Name);
        Assert.Equal(username, user.Username);
        Assert.Equal(email, user.Email);
        Assert.Empty(user.FriendList);
        Assert.Empty(user.ExternalLinks);
        // Assert.True(user.Visibility);
        // Assert.NotNull(user.Role);
        // Assert.Equal(password, user.Password);
    }
}