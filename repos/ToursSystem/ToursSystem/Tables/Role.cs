using System;
using System.Collections.Generic;
using System.Text;

namespace ToursSystem
{
    class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
