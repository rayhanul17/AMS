﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleTitle { get; set; }

        public List<User> Users { get; set; }
        
    }
}
