using Market.DataAcess;
using System;
using System.Data;

namespace Market.Business
{
    public class FavoriteService
    {
        private DBContext dbContext;

        public FavoriteService()
        {
            dbContext = new DBContext();
        }

        // إضافة منتج إلى قائمة المفضلات
        public int AddToFavorite(int userId, int productId)
        {
            string commandText = $"INSERT INTO Favorites (UserID, ProductID) VALUES ({userId}, {productId})";
            return dbContext.ExecuteNonQuery(commandText);
        }

        // حذف منتج من قائمة المفضلات
        public int RemoveFromFavorite(int favoriteId)
        {
            string commandText = $"DELETE FROM Favorites WHERE ID = {favoriteId}";
            return dbContext.ExecuteNonQuery(commandText);
        }

        // الحصول على قائمة المنتجات المفضلة للمستخدم
        public DataTable GetFavoritesByUserId(int userId)
        {
            string commandText = $"SELECT f.ID AS FavoriteID, p.Name, p.Price, p.Quantity, p.discription " +
                                 $"FROM Favorites f " +
                                 $"INNER JOIN Products p ON f.ProductID = p.ID " +
                                 $"WHERE f.UserID = {userId}";
            return dbContext.ExecuteQuery(commandText);
        }
    }
}
