using GoSocialApi.Models;
using System.Collections.Generic;

namespace GoSocialApi.Data
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAllComments();
        Comment GetCommentById(int id);
        void CreateComment(Comment comment);
        void UpdateComment(Comment comment);
        void DeleteComment(int id);
    }
}
