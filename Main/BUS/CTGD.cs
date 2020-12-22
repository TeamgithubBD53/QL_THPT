using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class CTGD
    {
        public DataTable Show(string tenlop)
        {
            string sql = @"select mh.TenMon, gv.HoTen, NgayDay, Tiet 
                           from tblCTGD ct, tblMonHoc mh, tblLop l, tblGiaoVien gv 
                            where ct.MaLop=l.MaLop and gv.MaMon=mh.MaMon and ct.MaGV=gv.MaGV and l.tenlop='" + tenlop + "'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public void ThemCTGD(string tenlop, string tengv, string tenmon, string ngayday, int tiet)
        {
            string sql = "ThemCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenlop", tenlop);
            cmd.Parameters.AddWithValue("@tengv", tengv);
            cmd.Parameters.AddWithValue("@tenmon", tenmon);
            cmd.Parameters.AddWithValue("@ngayday", ngayday);
            cmd.Parameters.AddWithValue("@tiet", tiet);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void SuaCTGD(string tenlop, string tenmon, string tengv, string ngayday, int tiet)
        {
            string sql = "SuaCTGD";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tenlop", tenlop);
            cmd.Parameters.AddWithValue("@tenmon", tenmon);
            cmd.Parameters.AddWithValue("@tengv", tengv);
            cmd.Parameters.AddWithValue("@ngayday", ngayday);
            cmd.Parameters.AddWithValue("@tiet", tiet);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        //Xoa
        public void XoaCTGD(string tenlop, string ngayday, string tiet)
        {
            string sql = "Xoa_CTDG";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenlop", tenlop);
            cmd.Parameters.AddWithValue("@ngayday", ngayday);
            cmd.Parameters.AddWithValue("@tiet", tiet);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
