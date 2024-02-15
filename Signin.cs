using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeAppForJenkins
{
    public class Signin
    {
        public string Authenticate(string username, string password)
        {
            string msg;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                msg = "UserName and Password Required";
            }
            else
            {
                if ((username == "admin") && (password == "admin123"))
                    msg = "Authentication Pass";
                else
                    msg = "Authentication Fail";
            }

            return msg;
        }
    }
}
