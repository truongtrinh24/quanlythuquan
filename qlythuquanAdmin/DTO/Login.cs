﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlythuquanAdmin.Model
{
    class Login
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public int RoleId { get; set; }
    }
}
