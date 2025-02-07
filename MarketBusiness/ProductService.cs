using Market.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Business
{
    public class ProductService
    {

        DBContext dbContext;
        public ProductService()
        {
            dbContext = new DBContext();
        }
        //select
        //public DataTable Getproducts()
        //{
        //    string commend = "SELECT p.ID, p.Name, c.Name AS CategoryName, c.ID AS CategoryID, p.Price, p.Quantity, p.Discription FROM Products p JOIN Categories c ON p.CategoryID = c.ID";
        //    DataTable dt =  dbContext.ExecuteQuery(commend);
        //    return dt;
        //}


        //insert 
        public int AddProduct(string ProductName ,int CatID,decimal ProductPrice,int Qut,string disc )
        {
            string commendText = $"INSERT INTO Products (Name, CategoryID, Price, Quantity, discription) VALUES ('{ProductName}', {CatID}, {ProductPrice}, '{Qut}', '{disc}')";
            return dbContext.ExecuteNonQuery(commendText);
        }

        //update
        public int UpdateProduct(int id, string ProductName, int CatID, decimal ProductPrice, string Qut, string disc)
        {
            string commendText = $"UPDATE Products SET Name='{ProductName}',CategoryID={CatID},Price = {ProductPrice}, Quantity = '{Qut}' ,discription='{disc}' WHERE ID = {id};";
            return dbContext.ExecuteNonQuery(commendText);
        }
        //delete
        public int DeleteProduct(int id)
        {
            string commendText = $"DELETE FROM Products WHERE ID = {id}";
            return dbContext.ExecuteNonQuery(commendText);
        }

        public DataTable GetProducts(string searchTerm = null)
        {
            string commandText;

            if (string.IsNullOrEmpty(searchTerm))
            {
                // جلب كل المنتجات
                commandText = "SELECT p.ID, p.Name, c.Name AS CategoryName, c.ID AS CategoryID, p.Price, p.Quantity, p.Discription FROM Products p JOIN Categories c ON p.CategoryID = c.ID";
            }
            else
            {
                // البحث عن المنتجات
                commandText = $"SELECT * FROM Products  WHERE Name LIKE '%{searchTerm}%'";
            }

            return dbContext.ExecuteQuery(commandText);
        }


    }
}
