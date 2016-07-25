using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Forum.BLL.Model
{
    class Category
    {
        public string Name{get; set;} 
        public string Description{get; set;}
        public string Creator{get; set;}
        public DateTime Created{get; set;}
        public int StatusID{get; set;}
        public int ParentCategoryID { get; set; }
    }
}
