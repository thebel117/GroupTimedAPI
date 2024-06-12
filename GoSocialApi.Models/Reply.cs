namespace GoSocialApi.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ParentId { get; set; }
        public int AuthorId { get; set; }
    }
}
