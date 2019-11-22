using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Permission
    {
        public enum perm
        {
            NONE, READ, WRITE, ALL
        };

        private  perm _permission;

        public  perm PermissionType { get => _permission; set => _permission = value; }
    }
}
