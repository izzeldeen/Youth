using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dto
{
    public class RegisterDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; } = 2;
    }
}
