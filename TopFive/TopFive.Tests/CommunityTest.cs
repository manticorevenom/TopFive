using System;
using System.Collections.Generic;
using Xunit;
using TopFive;

namespace TopFive.Tests
{
    public class CommunityTests
    {
        [Fact]
        public void AddPost_Method_Adds_Post_If_Not_Exists()
        {
            // Arrange
            var community = new Community();
            var post = new Post();

            // Act
            community.AddPost(post);

            // Assert
            Assert.Contains(post, community.Posts);
        }

        [Fact]
        public void AddPost_Method_Does_Not_Add_Duplicate_Post()
        {
            // Arrange
            var community = new Community();
            var post = new Post();

            // Act
            community.AddPost(post);
            community.AddPost(post); // Adding the same post again

            // Assert
            Assert.Single(community.Posts); // Ensuring only one instance of the post is added
        }

        [Fact]
        public void DeletePost_Method_Removes_Existing_Post()
        {
            // Arrange
            var community = new Community();
            var post = new Post();
            community.AddPost(post);

            // Act
            community.DeletePost(post);

            // Assert
            Assert.DoesNotContain(post, community.Posts);
        }

        [Fact]
        public void DeletePost_Method_Does_Not_Remove_Non_Existent_Post()
        {
            // Arrange
            var community = new Community();
            var post = new Post();

            // Act
            community.DeletePost(post);

            // Assert
            Assert.Empty(community.Posts); // No post should be added, so the list should be empty
        }

        [Fact]
        public void Constructor_Initializes_With_Default_Values()
        {
            // Arrange & Act
            var community = new Community();

            // Assert
            Assert.Equal(0, community.Members);
            Assert.Equal("", community.Id);
            // Assert.False(community.Visibility);
            Assert.Empty(community.Posts);
            Assert.Empty(community.Users);
        }

        [Fact]
        public void Constructor_Initializes_With_Given_Values()
        {
            // Arrange
            string id = "community123";
            bool visibility = true;

            // Act
            var community = new Community(id, visibility);

            // Assert
            Assert.Equal(0, community.Members);
            Assert.Equal(id, community.Id);
            // Assert.True(community.Visibility);
            Assert.Empty(community.Posts);
            Assert.Empty(community.Users);
        }
    }
}
