using Xunit;
using TopFive;

namespace TopFive.Tests
{
    public class PostTests
    {
        [Fact]
        public void Like_IncreasesLikesByOne()
        {
            // Arrange
            var post = new Post();

            // Act
            post.Like();

            // Assert
            Assert.Equal(1, post.Likes);
        }

        [Fact]
        public void Dislike_IncreasesDislikesByOne()
        {
            // Arrange
            var post = new Post();

            // Act
            post.Dislike();

            // Assert
            Assert.Equal(1, post.Dislikes);
        }

        [Fact]
        public void Update_UpdatesInfo()
        {
            // Arrange
            var post = new Post();
            string newInfo = "New Information";

            // Act
            post.Update(newInfo);

            // Assert
            Assert.Equal(newInfo, post.Info);
        }

        [Fact]
        public void Constructor_InitializesCorrectly()
        {
            // Arrange
            string id = "123";
            string info = "Initial Info";

            // Act
            var post = new Post(id, info);

            // Assert
            Assert.Equal(id, post.Id);
            Assert.Equal(info, post.Info);
            Assert.Equal(0, post.Likes);
            Assert.Equal(0, post.Dislikes);
        }
    }
}