using GoSocialApi.Models;
using System.Collections.Generic;

namespace GoSocialApi.Data
{
    public class CommentRepository : ICommentRepository
    {
        private readonly GoSocialContext _context;

        public CommentRepository(GoSocialContext context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetAllComments() => _context.Comments.ToList();

        public Comment GetCommentById(int id)
        {
            return _context.Comments.Find(id);
        }

        public void CreateComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void UpdateComment(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            var comment = _context.Comments.Find(id);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
                _context.SaveChanges();
            }
        }
    }
}
