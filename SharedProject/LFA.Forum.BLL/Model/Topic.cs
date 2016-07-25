using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Forum.BLL.Model
{
    class Topic
    {
       public string Subject{get; set;}
       public DateTime Created{get; set;}
       public int UserID{get; set;}
       public int StatusID{get; set;}
       public int CategoryID { get; set; }
    }
}
