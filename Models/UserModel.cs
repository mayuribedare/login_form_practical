using System.ComponentModel.DataAnnotations;

namespace AuthSystem.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Status { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
