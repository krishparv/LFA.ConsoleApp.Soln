using LFA.Forum.BLL.Model;
using LFA.Forum.DAL.Ado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Forum.BLL
{
    class TopicBLL
    {
        private SqlHelper _sqlhp;
        public TopicBLL()
        {
            _sqlhp = new SqlHelper();
        }

        public List<Topic> GetAllTopic()
        {
            var query = "Select * from Topic";
            var _sqlr = _sqlhp.ExecuteReader(query);
            List<Topic> listTopic = new List<Topic>();
            while (_sqlr.Read())
            {

                listTopic.Add(GetTopicDetails(_sqlr));
            }
            _sqlr.Close();
            return listTopic;


        }

        private static Topic GetTopicDetails(System.Data.SqlClient.SqlDataReader _sqlr)
        {
            var topic = new Topic();
            topic.Subject = _sqlr["Subject"].ToString();
            topic.Created = DateTime.Parse(_sqlr["Created"].ToString());
            topic.UserID = int.Parse(_sqlr["UserID"].ToString());
            topic.StatusID = int.Parse(_sqlr["StatusID"].ToString());
            topic.CategoryID = int.Parse(_sqlr["CategoryID"].ToString());
            return topic;
        }

        public Topic GetTopic(int id)
        {
            var query = "Select * from Topic where id=@id";
            var _sqlr = _sqlhp.ExecuteReader(query, "@id", id);
            Topic topic = new Topic();
            while (_sqlr.Read())
            {
                topic = GetTopicDetails(_sqlr);
            }
            _sqlr.Close();
            return topic;
        }

        public bool AddTopic(Topic topic)
        {
            SqlParameter[] param = new SqlParameter[]
            {
             new SqlParameter("@Subject",topic.Subject),
               new SqlParameter("@UserID",topic.UserID),
                 new SqlParameter("@CategoryID",topic.CategoryID),
                  new SqlParameter("@StatusID",topic.StatusID)
            };
            var checkpoint=_sqlhp.ExecuteNonQueryProc("uspAddTopic", param);
            if (checkpoint != -1)
                return true;
            else
                return false;

        }

        public bool UpdateTopic(Topic topic, int id)
        {
            SqlParameter[] param=new SqlParameter []
            {
                new SqlParameter("@ID",id),
                new SqlParameter("@Subject",topic.Subject),
                new SqlParameter("@StatusID",topic.StatusID),
                new SqlParameter("@CategoryId",topic.CategoryID)
            };
            var checkpoint= _sqlhp.ExecuteNonQueryProc("uspUpdateTopic", param);
            if (checkpoint != -1)
                return true;
            else
                return false;
        }

        public bool DeleteTopic(int id)
        {
            var query = "Delete from Topic where id=@id";
            var checkpoint= _sqlhp.ExecuteNonQuery(query, "@id", id);
            if (checkpoint == 1)
                return true;
            else
                return false;
        }
    }
}
