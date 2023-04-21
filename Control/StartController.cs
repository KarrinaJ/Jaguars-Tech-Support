using GUIForJTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jaguars_Tech_Support.Boundary;

namespace Control
{
    internal class StartController : Controller
    {
        public static void Initiate()
        {
            DBConnector.IntializeDB();
            
            LoginForm log = new LoginForm();
            log.Show();
            //The loginform "log" is being decoupled from Application.Run() so the entire application will not close whenever another form calls .Close() on the login page. 
            //Otherwise this would be Application.Run(new LoginForm())
            Application.Run();
            
        }
    }
}
