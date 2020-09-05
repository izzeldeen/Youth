using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dto
{
    public class EditProfileDto
    {
        public int Id { get; set; }
        public string Phonenumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Avatar { get; set; }
    }
}
