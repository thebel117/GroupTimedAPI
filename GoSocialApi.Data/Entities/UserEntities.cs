using System.ComponentModel.DataAnnotations;
using GoSocialApi.Models;
using Microsoft.AspNetCore.Identity;

namespace GoSocialApi.Data.Entities ;


public class UserEntity : IdentityUser<int> 
{ 
    [Key]
    public int Id { get; set; } 
    [Required] 
    [MaxLength(100)] 
    public string Email  { get; set; }
    [Required] 
    [MaxLength(100)]  
    public string Password { get; set; }
    [MaxLength(100)] 
    public string FirstName { get; set; } 
    [MaxLength(100)]
    public string LastName { get; set; } 

    public virtual List<Post> Posts{get; set;} = new List<Post>();
    public virtual List<Comment> Comments{get; set;} = new List<Comment>();
    public virtual List< Like> Likes{get; set;} = new List<Like>();
}