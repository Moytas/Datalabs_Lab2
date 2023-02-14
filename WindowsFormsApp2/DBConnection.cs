using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class DBConnection
    {
        SqlConnection con;
        string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Datalabs Student\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\AnimalsDB.mdf\";Integrated Security = True";
    
        public void AddToDatabase(Animal a)
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            string sql = string.Format("Insert into Reservations values({0},{1})", a.Name, DateTime.Now);
            SqlCommand command = new SqlCommand(sql,con);
            command.ExecuteScalar();
            con.Close();
            
        }

        public DateTime GetFromDatabase(string name)
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
            string sql = string.Format("Select EntranceDate from Reservations where Name = {0}", a.Name);
            SqlCommand command = new SqlCommand(sql, con);
            DateTime d = (DateTime)command.ExecuteScalar();
            con.Close();
            return d;
        }
    }
}
