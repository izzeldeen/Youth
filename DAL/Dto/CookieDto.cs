using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dto
{
    public class CookieDto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Avatar { get; set; }
    }
}
