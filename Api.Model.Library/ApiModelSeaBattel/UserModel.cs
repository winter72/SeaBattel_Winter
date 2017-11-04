using ModelLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Model.Library.ApiModelSeaBattel
{
    public class UserModel
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual UserAccount UserAccount { get; set; } 
    }
}
