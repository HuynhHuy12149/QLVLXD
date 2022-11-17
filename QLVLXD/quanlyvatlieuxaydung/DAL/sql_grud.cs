using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class sql_grud
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F10VF04\SQLEXPRESS;Initial Catalog=Quanlyvatlieuxaydung;Integrated Security=True");

        private void openconnect()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        private void closeconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();

            }
        }


        public Boolean excutedata(string cmd)
        {
            Boolean check = false;
            openconnect();
            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                // thi hành truy vấn - không cần trả về dữ liệu gì, phù hợp thực hiện các truy vấn như Update, Delete ...
                cmds.ExecuteNonQuery();
                check = true;


            }
            catch (Exception)
            {

                check = false;
            }
            closeconnect();

            return check;


        }

        public DataTable readdata(string cmd)
        {
            openconnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con); // cho pep chọn kiểu tương tác như insert và select
                SqlDataAdapter da = new SqlDataAdapter(cmds); //đổ dữ liệu vào data cho phép cập nhật database 
                da.Fill(dt);
                closeconnect();
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }


        }

        public string GetDataText(string sql)
        {
            string ketqua = "";
            openconnect();
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader sqldr = command.ExecuteReader();
            while (sqldr.Read())
            {
                ketqua = sqldr[0].ToString();
            }
            closeconnect();
            return ketqua;
        }
    }
}
