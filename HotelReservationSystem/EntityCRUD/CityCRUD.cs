using HotelReservationSystem.Entity;
using HotelReservationSystem.Utils;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace HotelReservationSystem.EntityCRUD
{
    public class CityCRUD : CRUD<City>
    {
        public void Create(City item)
        {
            string query = "INSERT INTO City (Name) VALUES (:cityName)";
            OracleParameter[] parameters = {
                new OracleParameter(":cityName", OracleDbType.Varchar2) { Value = item.CityName }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM City WHERE CityId = :cityId";
            OracleParameter[] parameters = {
                new OracleParameter(":cityId", OracleDbType.Int32) { Value = id }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<City> GetAll()
        {
            string query = "SELECT * FROM City";
            DataTable dataTable = DBConnection.GetData(query);
            List<City> cities = new List<City>();

            foreach (DataRow row in dataTable.Rows)
            {
                cities.Add(new City
                {
                    Id = int.Parse(row["CityId"].ToString()),
                    CityName = row["Name"].ToString()
                });
            }

            return cities;
        }

        public City GetById(int id)
        {
            string query = "SELECT * FROM City WHERE CityId = :cityId";
            OracleParameter[] parameters = {
                new OracleParameter(":cityId", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new City
                {
                    Id = int.Parse(row["CityId"].ToString()),
                    CityName = row["Name"].ToString()
                };
            }
            else
            {
                return null;
            }
        }

        public void Update(int id, City updatedItem)
        {
            string query = "UPDATE City SET Name = :newName WHERE CityId = :cityId";
            OracleParameter[] parameters = {
                new OracleParameter(":newName", OracleDbType.Varchar2) { Value = updatedItem.CityName },
                new OracleParameter(":cityId", OracleDbType.Int32) { Value = id }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }
    }
}