
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseReader
{
    public class DataBaseReaderL
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private readonly string connectionString = "Server = DESKTOP-VJ9A9DO; Database = Vehicle; Integrated Security = true;";
        private SqlConnection? connection;
        private SqlCommand? command;
        private SqlDataReader? dataReader;

        public void ConnectToDataSource()
        {
            connection = new SqlConnection(connectionString);
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM vehicle";

            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                Console.WriteLine("Can't open connection");
            }
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int vehicleID = reader.GetInt32(0);
                string vehicleModel = reader.GetString(1);
                int vehicleYear = reader.GetInt32(2);
                int vehicleCost = reader.GetInt32(3);

                Vehicle vehicle = new Vehicle(vehicleID, vehicleModel, vehicleYear, vehicleCost);
                vehicles.Add(vehicle);
            }

        }

        public void Disconnect()
        {
            if (connection == null)
            {
                return;
            }
            connection.Close();
            connection.Dispose();
            connection = null;
        }

        public IEnumerable<Vehicle> GetData()
        {
                if (vehicles == null)
                {
                    return new List<Vehicle>();

                }

                return vehicles.AsEnumerable();
        
        }
    }


}