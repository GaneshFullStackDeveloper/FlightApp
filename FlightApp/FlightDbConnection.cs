using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FlightApp
{
    public class FlightDbConnection
    {
        public static string ConnectionString = "Data Source=IN-L-7402600\\SQLEXPRESS;Initial Catalog=FlightBookingDb;Integrated Security=True";
        public string InsertFlight(string FlightName, string FlightType,string Country)
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Flights values('" + FlightName + "','" + FlightType + "','" + Country + "')", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "Inserted";
            return msg;
        }
        public string UpdateFlight(int productId, string productName, int productPrice)
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("update product set productname='" + productName + "' and productPrice= " + productPrice + " where productid=" + productId + ")", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "Updated";
            return msg;
        }
        public string DeleteFlights()
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("delete from product", con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "Deleted";
            return msg;
        }
        public string DeleteFlightByid(int FID)
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("delete from Flights where FID=" + FID, con);
            con.Open();
            int row = cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "Deleted flight: " + FID;
            return msg;
        }
        public DataTable SelectFlights()
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Flights", con);
            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            con.Close();
            return dt;
        }
        public DataTable SelectFlightById(int productId)
        {
            string msg = "";
            //connection establishment
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from product where productId=" + productId, con);
            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            con.Close();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            return dt;
        }
    }
}
