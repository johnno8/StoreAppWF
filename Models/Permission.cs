using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StoreAppWF.Models
{
    public class Permission
    {
        public int PermissionID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Title cannot be longer than 50 characters.")]
        public string Title { get; set; }
        [Required]
        [StringLength(150, ErrorMessage = "Description cannot be longer than 150 characters.")]
        public string Description { get; set; }

        public ICollection<UserPermission> UserPermissions { get; set; }
        //public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}