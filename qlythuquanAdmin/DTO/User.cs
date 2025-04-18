using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlythuquanAdmin.Model
{
    public class User
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
