using System.Collections.Generic; 
using GoSocialApi.Models; 
using GoSocialApi.Services; 
using GoSocialApi.WebApi.Services; 
using GoSocialApi.Data.Entities;

namespace GoSocialApi.Data 
{
    public class CommentService : ICommentService // CommentService class imp to ICommentService interface
    {
        private readonly ICommentService _commentService; // readonly field for the comment repo

        public CommentService(ICommentService commentService) // Constructor fr getting a repo dependency
        {
            _commentService = commentService; // Assigning  passed repo to the private field
        }

        public IEnumerable<Comment> GetAllComments() => _commentService.GetAllComments(); // Method delegating to the rep

        public Comment GetCommentById(int id) => _commentService.GetCommentById(id); // get a comment by ID delegate to the repo

        public void CreateComment(Comment comment) // create a new comment
        {
            _commentService.CreateComment(comment); // Delegating creation to repo
        }

        public void UpdateComment(Comment comment) // update  existing comment
        {
            _commentService.UpdateComment(comment); // update to the repo
        }

        public void DeleteComment(int id) // delete comment by ID
        {
            _commentService.DeleteComment(id); // del deletion to  repo
        }
    }
}