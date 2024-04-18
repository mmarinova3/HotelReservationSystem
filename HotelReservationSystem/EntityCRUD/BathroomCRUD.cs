using HotelReservationSystem.Entity;
using HotelReservationSystem.Utils;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System;

namespace HotelReservationSystem.EntityCRUD
{
    internal class BathroomCRUD : ICRUD<Bathroom>
    {
        public void Create(Bathroom item)
        {
            string query = "INSERT INTO Bathroom (BATHROOMID, FLOOR, ISHARED) VALUES (:id, :floor, :isShared)";
            OracleParameter[] parameters = {
                new OracleParameter(":BathroomId", OracleDbType.Int32) { Value = item.Id },
                new OracleParameter(":floor", OracleDbType.Varchar2) { Value = item.Floor },
                new OracleParameter(":isShared", OracleDbType.Boolean) { Value = item.IsShared }
    };
            DBConnection.ExecuteQuery(query, parameters);
        }


        public void Delete(int id)
        {
            string query = "DELETE FROM Bathroom WHERE BathroomId = :BathroomId";
            OracleParameter[] parameters = {
                new OracleParameter(":BathroomId", OracleDbType.Int32) { Value = id }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }

        public IEnumerable<Bathroom> GetAll()
        {
            string query = "SELECT * FROM Bathroom";
            DataTable dataTable = DBConnection.GetData(query);
            List<Bathroom> bathrooms = new List<Bathroom>();

            foreach (DataRow row in dataTable.Rows)
            {

                bathrooms.Add(new Bathroom
                {
                    Id = Convert.ToInt32(row["BathroomId"]),
                    Floor = Convert.ToInt32(row["Floor"]),
                    IsShared = Convert.ToString(row["IsShared"])
                });
            }

            return bathrooms;
        }

        public Bathroom GetById(int id)
        {
            string query = "SELECT * FROM Bathroom WHERE BathroomId = :bathroomId";
            OracleParameter[] parameters = {
                new OracleParameter(":bathroomId", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                return new Bathroom
                {
                    Id = Convert.ToInt32(row["BathroomId"]),
                    Floor = Convert.ToInt32(row["Floor"]),
                    IsShared = Convert.ToString(row["IsShared"])
                };
            }
            else
            {
                return null;
            }
        }


        public void Update(int id, Bathroom updatedItem)
        {
            string query = "UPDATE Bathroom SET Floor = :floor, IsShared = :isShared WHERE BathroomId = :bathroomId";
            OracleParameter[] parameters = {
                new OracleParameter(":floor", OracleDbType.Int32) { Value = updatedItem.Floor },
                new OracleParameter(":isShared", OracleDbType.Int32) { Value = updatedItem.IsShared },
                new OracleParameter(":bathroomId", OracleDbType.Int32) { Value = id }
            };
            DBConnection.ExecuteQuery(query, parameters);
        }

    }
}