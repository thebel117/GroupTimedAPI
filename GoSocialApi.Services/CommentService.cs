using System.Collections.Generic; 
using GoSocialApi.Models; 
using GoSocialApi.Services; 
using GoSocialApi.WebApi.Services; 

namespace GoSocialApi.Data 
{
    public class CommentService : ICommentService // CommentService class imp to ICommentService interface
    {
        private readonly ICommentRepository _commentRepository; // readonly field for the comment repo

        public CommentService(ICommentRepository commentRepository) // Constructor fr getting a repo dependency
        {
            _commentRepository = commentRepository; // Assigning  passed repo to the private field
        }

        public IEnumerable<Comment> GetAllComments() => _commentRepository.GetAllComments(); // Method delegating to the rep

        public Comment GetCommentById(int id) => _commentRepository.GetCommentById(id); // get a comment by ID delegate to the repo

        public void CreateComment(Comment comment) // create a new comment
        {
            _commentRepository.CreateComment(comment); // Delegating creation to repo
        }

        public void UpdateComment(Comment comment) // update  existing comment
        {
            _commentRepository.UpdateComment(comment); // update to the repo
        }

        public void DeleteComment(int id) // delete comment by ID
        {
            _commentRepository.DeleteComment(id); // del deletion to  repo
        }
    }
}
