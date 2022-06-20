using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_principles
{
    interface IUser
    {
        bool Login(string UserName, string passorld);
        bool Ragister(string UserName, string passworld, string Email);
    
       

    }

    interface ILogError{
       
        void logError(string error);

    }

    interface IEmail
    {
        bool SendEmail(string EmailContent);
    } 
}
