using LFA.Forum.DAL.Ado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LFA.Forum.BLL.Model;
using System.Data.SqlClient;

namespace LFA.Forum.BLL
{
    class CategoryBLL
    {
        private SqlHelper _sqlhp;
        public CategoryBLL()
        {
            _sqlhp = new SqlHelper();
        }

        public List<Category> GetAllCategoryDetail()
        {
            string query = "Select * from Category";
            var _sqlr = _sqlhp.ExecuteReader(query);

            List<Category> categorylist = new List<Category>();
            while (_sqlr.Read())
            {
                categorylist.Add(GetCategoryData(_sqlr));
            }
            _sqlr.Close();
            return categorylist;
        }

        private static Category GetCategoryData(System.Data.SqlClient.SqlDataReader _sqlr)
        {
            Category category = new Category();
            category.Name = _sqlr["Name"].ToString();
            category.Description = _sqlr["Descripiton"].ToString();
            category.Creator = _sqlr["Creator"].ToString();
            category.Created = DateTime.Parse(_sqlr["Created"].ToString());
            category.StatusID = int.Parse(_sqlr["StatusID"].ToString());
            category.ParentCategoryID = int.Parse(_sqlr["ParentCategoryID"].ToString());
            return category;
        }

        public Category GetCategoryFromId(int id)
        {
            Category category = new Category();
            string query = "select * from category where id=@id";
            var sqlr = _sqlhp.ExecuteReader(query, "@id", id);
            while (sqlr.Read())
            {
                category = GetCategoryData(sqlr);
            }
            sqlr.Close();
            return category;
        }

        public bool AddCategory(Category category)
        {
            SqlParameter[] param = new SqlParameter[] 
            {
                new SqlParameter("@CategoryName",category.Name),
                new SqlParameter("@StatusID",category.StatusID),
                new SqlParameter("@Description",category.Description),
                new SqlParameter("@ParentCategoryName",null),
                new SqlParameter("@Creator",category.Creator)
            };
            int checkpoint = _sqlhp.ExecuteNonQueryProc("uspAddCategory", param);
            if (checkpoint != -1)
                return true;
            else
                return false;
        }

        public bool UpdateCategoryStatus(int cid, int sid)
        {
             SqlParameter[] param = new SqlParameter[] 
            {
                new SqlParameter("@@CategoryID",cid),
                new SqlParameter("@StatusID",sid)                
            };
           int checkpoint= _sqlhp.ExecuteNonQuery("uspUpdateCategoryStatus",param);
          if (checkpoint != 1)
              return true;
          else
              return false;
        }

        public int DeleteCategory(int categoryId)
        {
            string query = "Delete from category where id=@id";
            return _sqlhp.ExecuteNonQuery(query, "@id", categoryId);
        }
    }
}
