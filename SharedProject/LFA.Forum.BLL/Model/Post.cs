using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Forum.BLL.Model
{
    class Post
    {
       public string Subject{get; set;}
       public string Context{get; set;}
       public DateTime Created{get; set;}
       public int TopicID{get; set;}
       public int UserID{get; set;}
       public int StatusID { get; set; }
    }
}
