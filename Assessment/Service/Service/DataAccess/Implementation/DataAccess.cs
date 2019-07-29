using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataAccess.Abstraction;
using Models;

namespace DataAccess.Implementation
{
    public class GenericDataAccess: IDataAccess
    {
        private SqlConnection GetConnection(string connectionName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString;
            return new SqlConnection(connectionString);
        }

        public List<Center> GetAllData()
        {
            using(var connection = GetConnection("DefaultConnection"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("GetAllCenterDetails", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                List<Center> ctrLst = new List<Center>();

                foreach(DataRow dr in dt.Rows)
                {
                    Center ctr = new Center();
                    ctr.CenterId = Convert.ToInt16(dr["CenterId"]);
                    ctr.CenterName = dr["Name"].ToString();
                    ctr.CenterCode = dr["Code"].ToString();
                    ctr.Address = dr["CenterDetail"].ToString();
                    ctr.PersonID = Convert.ToInt16(dr["PersonId"]);
                    ctr.PersonName = dr["PersonName"].ToString();
                    ctrLst.Add(ctr);
                }

                return ctrLst;
                
            }
        }
    }
}
