using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    internal class LogoutControl
    {
        public static void Logout(string email)
        {
           DBConnector.SaveLogout(email);
        }
    }
}
