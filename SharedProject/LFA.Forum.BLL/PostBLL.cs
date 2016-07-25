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
    class PostBLL
    {
         private SqlHelper _sqlhp;
        public PostBLL()
        {
            _sqlhp = new SqlHelper();
        }

        public List<Post> GetAllTopic()
        {
            var query = "Select * from Topic";
            var _sqlr = _sqlhp.ExecuteReader(query);
            List<Post> listPost = new List<Post>();
            while (_sqlr.Read())
            {
                listPost.Add(GetPostDetails(_sqlr));
            }
            _sqlr.Close();
            return listPost;


        }

        private static Post GetPostDetails(System.Data.SqlClient.SqlDataReader _sqlr)
        {
            var post = new Post();
            post.Subject = _sqlr["Subject"].ToString();
            post.Created = DateTime.Parse(_sqlr["Created"].ToString());
            post.UserID = int.Parse(_sqlr["UserID"].ToString());
            post.StatusID = int.Parse(_sqlr["StatusID"].ToString());
            post.Context = _sqlr["Context"].ToString();
            post.TopicID = int.Parse(_sqlr["TopicID"].ToString());
            return post;
        }

        public Post GetPost(int id)
        {
            var query = "Select * from Post where id=@id";
            var _sqlr = _sqlhp.ExecuteReader(query, "@id", id);
            Post post = new Post();
            while (_sqlr.Read())
            {
                post = GetPostDetails(_sqlr);
            }
            _sqlr.Close();
            return post;
        }

        public bool AddPost(Post post)
        {
            SqlParameter[] param = new SqlParameter[]
            {
             new SqlParameter("@Subject",post.Subject),
               new SqlParameter("@UserID",post.UserID),
                 new SqlParameter("@Context",post.Context),
                  new SqlParameter("@StatusID",post.StatusID),
                  new SqlParameter("TopicID",post.TopicID)
            };
            var checkpoint = _sqlhp.ExecuteNonQueryProc("uspAddPost", param);
            if (checkpoint != -1)
                return true;
            else
                return false;

        }

        public bool UpdatePost(Post post, int id)
        {
            SqlParameter[] param=new SqlParameter []
            {
                new SqlParameter("@ID",id),
                new SqlParameter("@Subject",post.Subject),
                new SqlParameter("@StatusID",post.StatusID),
                new SqlParameter("@Context",post.Context),
                new SqlParameter("@TopicID",post.TopicID)
            };
            var checkpoint= _sqlhp.ExecuteNonQueryProc("uspUpdatePost", param);
            if (checkpoint != -1)
                return true;
            else
                return false;
        }

        public bool DeletePost(int id)
        {
            var query = "Delete from Post where id=@id";
            var checkpoint= _sqlhp.ExecuteNonQuery(query, "@id", id);
            if (checkpoint == 1)
                return true;
            else
                return false;
        }
    }
}
