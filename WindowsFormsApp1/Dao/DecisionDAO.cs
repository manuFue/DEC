using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Dao
{
    public class DecisionDAO
    {
        public static bool Exists(int decisionNumber)
        {
            bool flag = false;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"SELECT TOP 1000
                                [IdDecision] FROM Decision WHERE IdDecision = @ID";
            cmd.Parameters.AddWithValue("@ID", decisionNumber);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                flag = true;
            dr.Close();
            cn.Close();
            return flag;
        }

        public static int MaxNumber()
        {
            int value = 0;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"SELECT MAX(IdDecision) [IdDecision] FROM Decision";
            value = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            return value;
        }

        public static void Insert(DecisionProblem Decision)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"INSERT INTO Decision (
                                    IdDecision, Name, Date) values (
                                    @IdDecision, @Name, @Date);select Scope_Identity() as IdDecision";
            cmd.Parameters.AddWithValue(@"IdDecision", Decision.IdProblem);
            cmd.Parameters.AddWithValue("@Name", Decision.Name);
            cmd.Parameters.AddWithValue("@Date", Decision.Date.ToShortDateString());
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
