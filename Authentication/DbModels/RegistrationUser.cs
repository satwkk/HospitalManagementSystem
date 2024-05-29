using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Authentication.DbModels
{
    public struct RegistrationUser : IExecutorModel
    {
        public string _userName { get; private set; }
        public string _email { get; set; }
        public string _password { get; private set; }
        public string _confirmPassword { get; private set; }

        public RegistrationUser( string userName, string email, string password, string confirmPassword )
        {
            _userName = userName;
            _password = password;
            _email = email;
            _confirmPassword = confirmPassword;
        }


        public List<string> GetValues()
        {
            return new List<string> { "employees", _userName, _email, _password };
        }
    }
}
