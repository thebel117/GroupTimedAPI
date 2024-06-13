using System.Collections.Generic; 
using GoSocialApi.Models; 
using GoSocialApi.Services; 
using GoSocialApi.WebApi.Services; 
using GoSocialApi.Data.Entities;

namespace GoSocialApi.Data
{
    public class PostService : IPostService
    {
        private readonly IPostService _postService;

        public PostService(IPostService postService)
        {
            _postService = postService;
        }

        public IEnumerable<Post> GetAllPosts() => _postService.GetAllPosts();

        public Post GetPostById(int id) => _postService.GetPostById(id);

        public void CreatePost(Post post)
        {
            _postService.CreatePost(post);
        }

        public void UpdatePost(Post post)
        {
            _postService.UpdatePost(post);
        }

        public void DeletePost(int id)
        {
            _postService.DeletePost(id);
        }
    }
}