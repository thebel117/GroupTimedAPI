using GoSocialApi.Models; 

namespace GoSocialApi.Services // Defining the namespace for the services layer
{
    public interface IPostService // Interface for PostService
    {
        IEnumerable<Post> GetAllPosts(); 
        Post GetPostById(int id); 
        void CreatePost(Post post); 
        void UpdatePost(Post post); 
        void DeletePost(int id);
    }
}
