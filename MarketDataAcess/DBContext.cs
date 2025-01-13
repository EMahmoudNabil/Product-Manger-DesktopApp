using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAcess
{


    public class DBContext
    {
        SqlConnection con;

        public DBContext()
        {
            con=new SqlConnection(@"Server=DESKTOP-8JFRNPP\SQLEXPRESS; Database=Market; Trusted_Connection=True; TrustServerCertificate=True");

        }
        //select command 
        public DataTable ExecuteQuery(string commandText)
        {
            //Disconnected mode
            SqlDataAdapter adapter = new();
            //or 
            //SqlDataAdapter adapter= new SqlDataAdapter();
            DataTable dt = new();

            //define command

            SqlCommand command = new(commandText, con);

            //attach
            adapter.SelectCommand= command;
            //get data
            adapter.Fill(dt);

            return dt;
        }

        //insert , update , delete

        public int ExecuteNonQuery(string commandText) { 
        
        //connected Mode

            //define command
            SqlCommand command = new(commandText, con);
            int rowsAffected;
            try
            {
                //open connection 
                con.Open();
                //execute
                 rowsAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
                    //log ex in file
            }
              finally
            {
                //colse Connection 
                con.Close();

               

            }

            return rowsAffected;

        }



        public object ExecuteScalar(string commandText)
        {
            SqlCommand command = new(commandText, con);
            object result;

            try
            {
                con.Open();
                result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing scalar command: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return result;
        }

    }
}
