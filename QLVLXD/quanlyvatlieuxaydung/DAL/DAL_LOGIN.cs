using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_LOGIN
    {
        sql_grud sql = new sql_grud();
        



        public DataTable readdata(string cmd, DTO_LOGIN LG)
        {

            string cmds = "select *  from NHANVIEN WHERE MaNV = N'" + LG.MaNV + "' and PassDN = N'" + LG.PassDN + "' and MaChucVu = N'"+LG.MaChucVu+"' " + cmd;
            return sql.readdata(cmds);

        }

        public bool readdatachange(string cmd, DTO_LOGIN LG)
        {

            string cmds = "select *  from NHANVIEN WHERE MaNV = N'" + LG.MaNV + "' and PassDN = N'" + LG.PassDN + "' " + cmd;
            return sql.excutedata(cmds);

        }
        public bool changedatapass(string cmd, DTO_LOGIN LG1)
        {

            string cmds = "update NHANVIEN set MaNV = N'"+LG1.MaNV+"' , PassDN = N'"+LG1.PassDN+"' where MaNV = N'"+LG1.MaNV+"' " + cmd;
            return sql.excutedata(cmds);

        }

        public DataTable readdatachucvu(string cmd)
        {

            string cmds = @"select * from CHUCVU " + cmd;
            return sql.readdata(cmds);

        }
    }
}
