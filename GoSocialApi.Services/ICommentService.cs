using GoSocialApi.Models;

namespace GoSocialApi.WebApi.Services
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetAllComments();
        Comment GetCommentById(int id);
        void CreateComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(int id);
    }
}
