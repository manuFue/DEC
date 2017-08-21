using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Dao
{
    public class StandardDao
    {
        public static List<Standard> GetStandards()
        {
            Standard Standard = null;
            List<Standard> StandardList = new List<Standard>();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT IdStandard, NameStandard, DescriptionStandard FROM Standard";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Standard = new Standard();
                Standard.IdStandard = int.Parse(dr["IdStandard"].ToString());
                Standard.Name = dr["NameStandard"].ToString();
                Standard.Description = dr["DescriptionStandard"].ToString();

                StandardList.Add(Standard);
            }
            dr.Close();
            cn.Close();
            return StandardList;
        }
    }
}
