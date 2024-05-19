using HotelReservationSystem.Entity;
using HotelReservationSystem.Utils;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem.EntityCRUD
{
    public class RoleCRUD : ICRUD<Role>
    {
        public void Create(Role item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public Role GetById(int id)
        {
            string query = "SELECT * FROM Role WHERE Id = :roleId";
            OracleParameter[] parameters = {
                new OracleParameter(":roleId", OracleDbType.Int32) { Value = id }
            };

            DataTable dataTable = DBConnection.GetData(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                return new Role
                {
                    Id = int.Parse(row["Id"].ToString()),
                    RoleName = row["RoleName"].ToString()
                };
            }
            else
            {
                return null;
            }
        }

        public void Update(int id, Role updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
  
