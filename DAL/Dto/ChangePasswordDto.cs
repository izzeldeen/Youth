﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dto
{
    public class ChangePasswordDto
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
