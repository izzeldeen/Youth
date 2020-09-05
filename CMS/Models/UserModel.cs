using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Models
{
    public class UserModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public List<Role> Roles { get; set; }
    }
}
