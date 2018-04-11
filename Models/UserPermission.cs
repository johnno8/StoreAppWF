using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StoreAppWF.Models
{
    public class UserPermission
    {
        [Key]
        public int UserPermissionID { get; set; }
        public int UserID { get; set; }
        public int PermissionID { get; set; }

        public virtual User User { get; set; }
        public virtual Permission Permission { get; set; }
    }
}