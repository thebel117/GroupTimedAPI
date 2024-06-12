using GoSocialApi.Models;
using System.Collections.Generic;

namespace GoSocialApi.Data
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);
        void CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int id);
    }
}
