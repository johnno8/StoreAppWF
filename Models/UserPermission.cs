﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace StoreAppWF.Models
{
    public class UserPermission
    {
        public int UserID { get; set; }
        public int PermissionID { get; set; }

        public User User { get; set; }
        public Permission Permission { get; set; }
    }
}