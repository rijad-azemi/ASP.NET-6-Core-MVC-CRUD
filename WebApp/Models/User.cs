using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class User
    {
        [Key]
        public Guid User_Id { get; set; }
        public string User_Email { get; set; }
        public string User_Password { get; set; }
    }
}
