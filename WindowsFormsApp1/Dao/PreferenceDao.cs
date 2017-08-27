using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Dao
{
    public class PreferenceDao
    {
        public static void Insert(int IdDECISION, Standard MainStandard, Standard PreferenceStandard, int value)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"INSERT INTO Preference (
                                    IdDecision, IdMainStandard, IdPreferenceStandard, Value) values (
                                    @IdDecision, @IdMain, @IdPreference, @Value);select Scope_Identity() as IdMainStandard";
            cmd.Parameters.AddWithValue(@"IdDecision", IdDECISION);
            cmd.Parameters.AddWithValue("@IdMain", MainStandard.IdStandard);
            cmd.Parameters.AddWithValue("@IdPreference", PreferenceStandard.IdStandard);
            cmd.Parameters.AddWithValue("@Value", value);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
