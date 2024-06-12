using GoSocialApi.Models;
using GoSocialApi.Services;

namespace GoSocialApi.Data
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IEnumerable<Post> GetAllPosts() => _postRepository.GetAllPosts();

        public Post GetPostById(int id) => _postRepository.GetPostById(id);

        public void CreatePost(Post post)
        {
            _postRepository.CreatePost(post);
        }

        public void UpdatePost(Post post)
        {
            _postRepository.UpdatePost(post);
        }

        public void DeletePost(int id)
        {
            _postRepository.DeletePost(id);
        }
    }
}
