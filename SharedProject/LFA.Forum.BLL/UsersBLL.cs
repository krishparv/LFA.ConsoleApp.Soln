using LFA.Forum.BLL.Model;
using LFA.Forum.DAL;
using LFA.Forum.DAL.Ado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Forum.BLL
{
    public class UsersBLL
    {

        private SqlHelper _sqlhp;
        #region Constructor

     
        public UsersBLL()
        {
            
            _sqlhp = new SqlHelper();
        }
        #endregion
        public List<Users> GetAllUsersDetail()
        {
          string query = "Select * from Users";
          var _sqlr=_sqlhp.ExecuteReader(query);

          List<Users> userlist = new List<Users>();
          while (_sqlr.Read())
          {
             userlist.Add(GetUserData(_sqlr));
          }
          _sqlr.Close();
          return userlist;
        }

        private static Users GetUserData(System.Data.SqlClient.SqlDataReader _sqlr)
        {
            Users user = new Users();
            user.UserName = _sqlr["UserName"].ToString();
            user.HashPassword = _sqlr["HashPassword"].ToString();
            user.FirstName = _sqlr["FirstName"].ToString();
            user.LastName = _sqlr["LastName"].ToString();
            user.Email = _sqlr["Email"].ToString();
            user.Created = _sqlr["Created"].ToString() == "" ? 0 : int.Parse(_sqlr["Created"].ToString());
            user.LastActivity = DateTime.Parse(_sqlr["LastActivity"].ToString());
            user.IsModerator = bool.Parse(_sqlr["IsModerator"].ToString());
            user.UserStatus = int.Parse(_sqlr["UserStatus"].ToString());
            return user;
        }

        public Users GetUserFromId(int id)
        {
            Users user = new Users();
            string query = "select * from Users where id=@id";
            var sqlr=_sqlhp.ExecuteReader(query, "@id", id);
            while(sqlr.Read())
            {
               user=GetUserData(sqlr);
            }
            sqlr.Close();
            return user;
        }

        public bool AddUser(Users user)
        {
            string query = "Insert into Users (UserName,HashPassword,FirstName,LastName,Email,Created,LastActivity,IsModerator,UserStatus) values(@username,@hashPwd,@fname,@lname,@email,@created,@lActivity,@isModerator,@userStatus)";
            int checkpoint = _sqlhp.ExecuteNonQuery(query, "@username",user.UserName, "@hashPwd",user.HashPassword, "@fname",user.FirstName, "@lname",user.LastName,"@email",user.Email,"@created",user.Created,"@lActivity",user.LastActivity,"@isModerator",user.IsModerator,"@userStatus",user.UserStatus);
            if (checkpoint != -1)
                return true;
            else
                return false;
        }

        public bool UpdateUser(Users user)
        {
            string query = "update Users set UserName=@username,HashPassword=@hashPwd,FirstName=@fname,LastName=@lname,Email=@email,Created=@created,LastActivity=@lActivity,IsModerator=@isModerator,UserStatus=@usersStatus";
          int checkpoint= _sqlhp.ExecuteNonQuery(query,"@username",user.UserName, "@hashPwd",user.HashPassword, "@fname",user.FirstName, "@lname",user.LastName,"@email",user.Email,"@created",user.Created,"@lActivity",user.LastActivity,"@isModerator",user.IsModerator,"@usersStatus",user.UserStatus);
          if (checkpoint != 1)
              return true;
          else
              return false;
        }

        public int DeleteUser(int userId)
        {
            string query = "Delete from user where id=@id";
          return  _sqlhp.ExecuteNonQuery(query, "@id", userId);
        }
    }
}
