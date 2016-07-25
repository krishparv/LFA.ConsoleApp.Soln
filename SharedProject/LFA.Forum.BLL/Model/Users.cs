using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Forum.BLL.Model
{
   public class Users
    {
       public string UserName{get; set;}
       public string HashPassword{get; set;}
       public string FirstName{get; set;}
       public string LastName{get; set;}
       public string Email {get; set;}
       public int Created{get; set;}
       public DateTime LastActivity{get; set;}
       public bool IsModerator{get; set;}
       public int UserStatus{get; set;}
    }
}
