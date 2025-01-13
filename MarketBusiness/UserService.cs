using Market.DataAcess;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Market.Business
{
    public class UserService
    {
        DBContext dbContext;

        public UserService()
        {
            dbContext = new DBContext();
        }

        // استرجاع جميع المستخدمين
        public DataTable GetUsers()
        {
            try
            {
                string command = "SELECT ID, Name, Email, Age, Address, Role FROM Users";
                return dbContext.ExecuteQuery(command);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching users: {ex.Message}");
            }
        }

        public DataTable GetCurrentUser(int id)
        {
            try
            {
                string command = $"SELECT ID, Name, Email, Age, Address, Role FROM Users  WHERE ID = {id}";
                return dbContext.ExecuteQuery(command);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching users: {ex.Message}");
            }
        }

        // إضافة مستخدم جديد
        public int AddUser(string name, string password, string email, int age, string address, string role)
        {
            try
            {
                string commandText = $"INSERT INTO Users (Name, Pass, Email, Age, Address, Role) VALUES ('{name}','{password}', '{email}', {age}, '{address}', '{role}')";



                return dbContext.ExecuteNonQuery(commandText);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding user: {ex.Message}");
            }
        }

        // تعديل بيانات المستخدم
        public int UpdateUser(int id, string name, string email, int age, string address)
        {
            try
            {
                string commandText = $"UPDATE Users  SET Name = '{name}',  Email = '{email}', Age = {age}, Address = '{address}'  WHERE ID = {id}";



                return dbContext.ExecuteNonQuery(commandText);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating user: {ex.Message}");
            }
        }

        // حذف مستخدم
        public int DeleteUser(int id)
        {
            try
            {
                string commandText = "DELETE FROM Users WHERE ID = @ID";

                return dbContext.ExecuteNonQuery(commandText);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting user: {ex.Message}");
            }
        }


        public DataTable Login(string name, string password)
        {
            string commandText = $"SELECT * FROM Users WHERE Name = '{name}' AND Pass = '{password}'";
            return dbContext.ExecuteQuery(commandText);
        }
        // مصادقة المستخدم بناءً على الاسم وكلمة المرور
        public DataTable AuthenticateUser(string name, string password)
        {
            try
            {



                string commandText = $"SELECT ID, Role ,Name FROM Users WHERE Name = '{name.Replace("'", "''")}' AND Pass = '{password.Replace("'", "''")}'";


                return dbContext.ExecuteQuery(commandText);
            }
            catch (Exception ex)
            {
                // Log the exception: Log.Error(ex);
                throw new Exception("Authentication failed due to a system error.");
            }
        }

        public bool CheckOldPassword(int userId, string oldPassword)
        {
            // استخدم SQL للتحقق من كلمة المرور القديمة
            try
            {
                string command = $"SELECT Pass FROM Users WHERE ID = {userId}";
                //SqlCommand sqlCommand = new SqlCommand(command);
                //sqlCommand.Parameters.AddWithValue("@userId", userId);
                var result = dbContext.ExecuteScalar(command); // استعلام للبحث عن كلمة المرور القديمة في قاعدة البيانات

                return result.ToString() == oldPassword; // مقارنة كلمة المرور المدخلة مع المخزنة
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred: " + ex.Message);

            }
        }

        // تحديث كلمة المرور في قاعدة البيانات
        public int UpdatePassword(int userId, string newPassword)
        {
            try
            {
                string commandText = $" UPDATE Users SET Pass = '{newPassword}'  WHERE ID = {userId}";



                return dbContext.ExecuteNonQuery(commandText);// إرجاع 0 في حال الفشل >0 في حال النجاح
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while updating the password: " + ex.Message);

            }



        }
    }
}