using GoSocialApi.Models;

namespace GoSocialApi.Services
{
    public interface IPostService
    {
        IEnumerable<Post> GetAllPosts();
        Post GetPostById(int id);
        //CreatePost
        //UpdatePost
        //DeletePost

    }
}