using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Models
{
    [Table("UsersAccount")]
     public class UserAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserAccountId { get; set; }

        [Required, MaxLength(128), Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        public string HashPassword { get; set; }

        [Required]
        public string Salt { get; set; }

        public bool IsActivated { get; set; }

        public Guid VerifyCode { get; set; }
    }
}
