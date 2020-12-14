using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class GiaoVien
    {
        public DataTable Show()
        {
            string sql = "SELECT gv.MaGV, gv.HoTen, gv.GT, gv.NgaySinh, gv.DiaChi, gv.Luong, gv.SDT, mh.TenMon FROM tblGiaoVien gv, tblMonHoc mh where gv.MaMon = mh.MaMon";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
        public DataTable Show(string tenmon)
        {
            string sql = "SELECT gv.MaGV, gv.HoTen FROM tblGiaoVien gv, tblMonHoc mh where gv.MaMon = mh.MaMon and mh.TenMon=N'" + tenmon + "'";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }
    }
}
