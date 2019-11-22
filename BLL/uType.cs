using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class uType
    {
        public enum userTypes
        {
            ADMIN,DOCTOR,PATIENT
        };

        private userTypes _userType;

        public userTypes UserType { get => _userType; set => _userType = value; }
    }
}
