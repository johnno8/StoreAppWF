using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StoreAppWF.Models
{
    
    public class DBInitializer : DropCreateDatabaseAlways<StoreAppWFContext>
    {
        protected override void Seed(StoreAppWFContext context)
        {
            GetUsers().ForEach(u => context.Users.Add(u));
            GetPermissions().ForEach(p => context.Permissions.Add(p));
            GetUserPermissions().ForEach(up => context.UserPermissions.Add(up));
        }

        private static List<User> GetUsers()
        {
            var users = new List<User> {
            new User{Name="Jim Fig",Address="Portlaw, Co. Waterford",Nationality="Irish"},
            new User{Name="Jane Doe",Address="Kilmacow, Co. Kilkenny",Nationality="American"},
            new User{Name="Joe Bloggs",Address="Carrick on Suir, Co. Tipperary",Nationality="British"},
            new User{Name="Ann Other",Address="Ferrybank, Co. Waterford",Nationality="Irish"}
            };

            return users;
        }

        private static List<Permission> GetPermissions()
        {
            var permissions = new List<Permission> {
            new Permission{Title="ReadOnly",Description="Restricted to Read Only access"},
            new Permission{Title="Write",Description="Allows Read and Write access"},
            new Permission{Title="Delete",Description="Allows user to Delete files"}
            };

            return permissions;
        }

        private static List<UserPermission> GetUserPermissions()
        {
            var userpermissions = new List<UserPermission> {
                new UserPermission {UserPermissionID=1,UserID=1,PermissionID=2},
                new UserPermission {UserPermissionID=2,UserID=1,PermissionID=3},
                new UserPermission {UserPermissionID=3,UserID=2,PermissionID=1},
                new UserPermission {UserPermissionID=4,UserID=3,PermissionID=2},
                new UserPermission {UserPermissionID=5,UserID=4,PermissionID=2},
            };

            return userpermissions;
        }
        /*
        private static List<UserPermission> GetUserPermissions()
        {
            var userpermissions = new List<UserPermission> {
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Jim Fig").ID,
                    PermissionID = permissions.Single(p => p.Title == "Write").PermissionID
                },
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Jim Fig").ID,
                    PermissionID = permissions.Single(p => p.Title == "Delete").PermissionID
                },
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Jane Doe").ID,
                    PermissionID = permissions.Single(p => p.Title == "ReadOnly").PermissionID
                },
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Joe Bloggs").ID,
                    PermissionID = permissions.Single(p => p.Title == "Write").PermissionID
                },
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Ann Other").ID,
                    PermissionID = permissions.Single(p => p.Title == "Write").PermissionID
                }
            };

            return userpermissions;
        }*/
    }

    /*
    public class DbInitializer 
    {
        public static void Initialize(StoreAppWFContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            } 

            var users = new User[]
            {
            new User{Name="Jim Fig",Address="Portlaw, Co. Waterford",Nationality="Irish"},
            new User{Name="Jane Doe",Address="Kilmacow, Co. Kilkenny",Nationality="American"},
            new User{Name="Joe Bloggs",Address="Carrick on Suir, Co. Tipperary",Nationality="British"},
            new User{Name="Ann Other",Address="Ferrybank, Co. Waterford",Nationality="Irish"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var permissions = new Permission[]
            {
            new Permission{Title="ReadOnly",Description="Restricted to Read Only access"},
            new Permission{Title="Write",Description="Allows Read and Write access"},
            new Permission{Title="Delete",Description="Allows user to Delete files"}
            };
            foreach (Permission p in permissions)
            {
                context.Permissions.Add(p);
            }
            context.SaveChanges();

            var userpermissions = new UserPermission[]
            {
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Jim Fig").ID,
                    PermissionID = permissions.Single(p => p.Title == "Write").PermissionID
                },
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Jim Fig").ID,
                    PermissionID = permissions.Single(p => p.Title == "Delete").PermissionID
                },
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Jane Doe").ID,
                    PermissionID = permissions.Single(p => p.Title == "ReadOnly").PermissionID
                },
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Joe Bloggs").ID,
                    PermissionID = permissions.Single(p => p.Title == "Write").PermissionID
                },
                new UserPermission {
                    UserID = users.Single(u => u.Name == "Ann Other").ID,
                    PermissionID = permissions.Single(p => p.Title == "Write").PermissionID
                }
            };
            foreach (UserPermission u in userpermissions)
            {
                context.UserPermissions.Add(u);
            }
            context.SaveChanges();
        }
    } */
}