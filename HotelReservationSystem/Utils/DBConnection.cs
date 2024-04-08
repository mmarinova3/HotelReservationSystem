using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace HotelReservationSystem.Utils
{
    public class DBConnection
    {
        public static string ConnectionString = @"Data Source=localhost:1521/xe;Persist Security Info=True;User ID=TSPHotel;Password=12345";

        public static bool ExecuteQuery(string query, OracleParameter[] parameters = null)
        {
            using (OracleConnection connection = new OracleConnection(ConnectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }
        }

        public static DataTable GetData(string query, OracleParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (OracleConnection connection = new OracleConnection(ConnectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    try
                    {
                        connection.Open();
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return dataTable;
        }
    }
}