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
    public class DAL_hoadon
    {
        sql_grud sql = new sql_grud();

        public DataTable readdatadg(string cmd)
        {
            string cmds = "select * from HOADONBAN" + cmd;
            return sql.readdata(cmds);
        }

        public DataTable readdataKH(string cmd)
        {
            string cmds = "select * from KHACHHANG" + cmd;
            return sql.readdata(cmds);
        }

        public DataTable readdataNV(string cmd)
        {
            string cmds = "select * from NHANVIEN" + cmd;
            return sql.readdata(cmds);
        }

        public Boolean them(string cmd, DTO_hoadon dtohoadon)
        {
            string cmds = @"INSERT INTO HOADONBAN (MaHD,MaNV,MaKH,NgayBan,TongTienBan) VALUES (N'" + dtohoadon.MaHD + "',N'" + dtohoadon.MaNV + "',N'" + dtohoadon.MaKH + "',N'" + dtohoadon.NgayBan + "',N'" + dtohoadon.TongTienBan + "')" + cmd;
            return sql.excutedata(cmds);


        }

        public Boolean sua(string cmd, DTO_hoadon dtohoadon)
        {
            string cmds = @"UPDATE HOADONBAN SET MaHD= N'" + dtohoadon.MaHD + "',MaNV = N'" + dtohoadon.MaNV + "',MaKH = N'" + dtohoadon.MaKH + "',NgayBan = N'" + dtohoadon.NgayBan + "',N'" + dtohoadon.TongTienBan + "'" + cmd;
            return sql.excutedata(cmds);


        }

        public Boolean xoa(string cmd, DTO_hoadon dtohoadon)
        {
            string cmds = @"delete from HOADONBAN  where MaHD= N'" + dtohoadon.MaHD + "'" + cmd;
            return sql.excutedata(cmds);


        }

        public DataTable timkiem(string cmd, DTO_hoadon dtohoadon)
        {
            string cmds = @"select * from HOADONBAN  where TenKH like N'%" + dtohoadon.MaHD + "'" + cmd;
            return sql.readdata(cmds);


        }
    }
}
