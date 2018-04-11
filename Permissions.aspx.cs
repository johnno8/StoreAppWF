using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using StoreAppWF.Models;

namespace StoreAppWF
{
    public partial class Permissions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Permission> permissionsGrid_GetData()
        {
            StoreAppWFContext db = new StoreAppWFContext();
            var query = db.Permissions.Include(p => p.UserPermissions.Select(up => up.User));
            return query;
        }
    }
}