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
            cmd.CommandText = "SELECT IdStandard, NameStandard, DescriptionStandard, Optimization FROM Standard";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Standard = new Standard();
                Standard.IdStandard = int.Parse(dr["IdStandard"].ToString());
                Standard.Name = dr["NameStandard"].ToString();
                Standard.Description = dr["DescriptionStandard"].ToString();
                Standard.Optimization = Convert.ToBoolean(dr["Optimization"]);

                StandardList.Add(Standard);
            }
            dr.Close();
            cn.Close();
            return StandardList;
        }

        public static List<Standard> GetStandards(string NAME)
        {
            Standard Standard = null;
            List<Standard> StandardList = new List<Standard>();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT IdStandard, NameStandard, DescriptionStandard, Optimization FROM Standard " +
                              "WHERE NameStandard LIKE @Name";
            cmd.Parameters.AddWithValue("@Name", NAME + "%");
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Standard = new Standard();
                Standard.IdStandard = int.Parse(dr["IdStandard"].ToString());
                Standard.Name = dr["NameStandard"].ToString();
                Standard.Description = dr["DescriptionStandard"].ToString();
                Standard.Optimization = Convert.ToBoolean(dr["Optimization"]);

                StandardList.Add(Standard);
            }
            dr.Close();
            cn.Close();
            return StandardList;
        }

        public static Standard GetByID(int? IdSTANDARD)
        {
            Standard standard = null;
            SqlConnection cn = new SqlConnection();

            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"SELECT 
                                [IdStandard], 
                                [NameStandard],
                                [DescriptionStandard],
                                [Optimization] FROM Standard WHERE IdStandard = @id";
            cmd.Parameters.AddWithValue("@id", IdSTANDARD);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                standard = new Standard()
                {
                    Name = dr["NameStandard"].ToString(),
                    Description = dr["DescriptionStandard"].ToString(),
                    IdStandard = (int)dr["IdStandard"],
                    Optimization = Convert.ToBoolean(dr["Optimization"])
                };

            }
            dr.Close();
            cn.Close();
            return standard;
        }

        public static void Update(Entidades.Standard standard)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"UPDATE Standard SET 
                                    NameStandard = @Name,
                                    DescriptionStandard = @Description,
                                    Optimization = @Optimization                                    
                                WHERE IdStandard = @ID";
            cmd.Parameters.AddWithValue("@ID", standard.IdStandard);
            cmd.Parameters.AddWithValue("@Name", standard.Name);
            cmd.Parameters.AddWithValue("@Description", standard.Description);
            cmd.Parameters.AddWithValue("@Optimization", standard.Optimization);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void Delete(int IdStandard)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"DELETE FROM Standard WHERE IdStandard = @ID";
            cmd.Parameters.AddWithValue("@ID", IdStandard);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static int? Insert(Standard Standard)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConnectionString.Cadena();
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = @"INSERT INTO Standard (
                                    NameStandard, DescriptionStandard, Optimization) values (
                                    @NameStandard, @DescriptionStandard, @Optimization);select Scope_Identity() as IdStandard";
            cmd.Parameters.AddWithValue("@NameStandard", Standard.Name);
            cmd.Parameters.AddWithValue("@DescriptionStandard", Standard.Description);
            cmd.Parameters.AddWithValue("@Optimization", Standard.Optimization);
            Standard.IdStandard = Convert.ToInt32(cmd.ExecuteScalar());
            cn.Close();
            return Standard.IdStandard;
        }

        //public static stringd> GetDescriptionByStandard(string NAME)
        //{
        //    Standard Standard = null;
        //    List<Standard> StandardList = new List<Standard>();
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = ConnectionString.Cadena();
        //    cn.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = cn;
        //    cmd.CommandText = "SELECT IdStandard, NameStandard, DescriptionStandard FROM Standard";
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Standard = new Standard();
        //        Standard.IdStandard = int.Parse(dr["IdStandard"].ToString());
        //        Standard.Name = dr["NameStandard"].ToString();
        //        Standard.Description = dr["DescriptionStandard"].ToString();

        //        StandardList.Add(Standard);
        //    }
        //    dr.Close();
        //    cn.Close();
        //    return StandardList;
        //}
    }
}
