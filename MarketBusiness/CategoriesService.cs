using Market.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business
{
    public class CategoriesService
    {
        DBContext dbContext;
        public CategoriesService()
        {
            dbContext = new DBContext();

        }
        //select All Category
        public DataTable GetCategory()
        {
            string commend = "select ID, Name from Categories";
            DataTable dt = dbContext.ExecuteQuery(commend);
            return dt;
        }

        //insert 
        public int addCategory(string categoryName) {
            string commendText = $"INSERT INTO Categories ([Name]) VALUES ('{categoryName}')";
           return dbContext.ExecuteNonQuery(commendText);
        }

        //update
        public int UpdateCategory(int IDCat, string categoryName)
        {
            string commendText = $"UPDATE Categories SET Name = '{categoryName}' WHERE ID = {IDCat}";
            return dbContext.ExecuteNonQuery(commendText);
        }
        //delete
        public int deleteCategory(int IDCat)
        {
            string commendText = $"DELETE FROM Categories WHERE ID = {IDCat}";
            return dbContext.ExecuteNonQuery(commendText);
        }
    }
}
