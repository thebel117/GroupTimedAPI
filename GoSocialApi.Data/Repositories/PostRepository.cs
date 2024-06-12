using GoSocialApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace GoSocialApi.Data
{
    public class PostRepository : IPostRepository
    {
        private readonly GoSocialContext _context;

        public PostRepository(GoSocialContext context)
        {
            _context = context;
        }

        public IEnumerable<Post> GetAllPosts() => _context.Posts.ToList();

        public Post GetPostById(int id) => _context.Posts.Find(id);

        public void CreatePost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        public void UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
        }

        public void DeletePost(int id)
        {
            var post = _context.Posts.Find(id);
            if (post != null)
            {
                _context.Posts.Remove(post);
                _context.SaveChanges();
            }
        }
    }
}
