using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.DbModels
{
    public struct LoginUser : IExecutorModel
    {
        public string _userName { get; private set; }
        public string _password { get; private set; }

        public LoginUser( string username, string password )
        {
            _userName = username;
            _password = password;
        }

        public readonly bool Equals( LoginUser rhs )
        {
            return _userName == rhs._userName && _password == rhs._password;
        }

        public List<string> GetValues()
        {
            return new List<string> { "employees", _userName, _password };
        }
    }
}
