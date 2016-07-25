using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Forum.BLL.Model
{
    class Vote
    {
        public int UpCount{get; set;}
        public int DownCount{get; set;}
        public int TopicID{get; set;}
        public int PostID{get; set;}
        public int UserID{get;set;}
        public DateTime VotedDate { get; set; }
    }
}
