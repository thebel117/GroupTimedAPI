namespace GoSocialApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int AuthorId { get; set; }
        public int PostId { get; set; }
        public virtual List<Reply> Replies { get; set; }
    }
}
