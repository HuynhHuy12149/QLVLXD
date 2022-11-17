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
    public class DAL_nhanvien
    {
        sql_grud sql = new sql_grud();

        public DataTable readdatanv(string cmd)
        {
            string cmds = "select * from NHANVIEN" + cmd;
            return sql.readdata(cmds);
        }
        public DataTable readdatachucvu(string cmd)
        {
            string cmds = "select * from CHUCVU" + cmd;
            return sql.readdata(cmds);
        }

        public Boolean themnhanvien(string cmd, DTO_nhanvien dtonhanvien)
        {
            string cmds = @"INSERT INTO NHANVIEN (MaNV,TenNV,MaChucVu,DiaChiNV,SDT,GioiTinh,NgaySinh,TenDN,PassDN) VALUES (N'" + dtonhanvien.MaNV + "',N'" + dtonhanvien.TenNV + "',N'" + dtonhanvien.MaChucVu + "',N'" + dtonhanvien.DiaChiNV + "',N'" + dtonhanvien.SDT + "',N'" + dtonhanvien.GioiTinh + "',N'" + dtonhanvien.NgaySinh + "',N'" + dtonhanvien.TenDN + "',N'" + dtonhanvien.PassDN + "')" + cmd;
            return sql.excutedata(cmds);


        }

        public Boolean suanhanvien(string cmd, DTO_nhanvien dtonhanvien)
        {
            string cmds = @"UPDATE NHANVIEN SET MaNV = N'" + dtonhanvien.MaNV + "',TenNV = N'" + dtonhanvien.TenNV + "',MaChucVu = N'" + dtonhanvien.MaChucVu + "',DiaChiNV = N'" + dtonhanvien.DiaChiNV + "',SDT = N'" + dtonhanvien.SDT + "',GioiTinh =  N'" + dtonhanvien.GioiTinh + "',NgaySinh = N'" + dtonhanvien.NgaySinh + "',TenDN=N'" + dtonhanvien.TenDN + "',PassDN=N'" + dtonhanvien.PassDN + "' WHERE MaNV = N'" + dtonhanvien.MaNV + "'" + cmd;
            return sql.excutedata(cmds);


        }

        public Boolean xoanhanvien(string cmd, DTO_nhanvien dtonhanvien)
        {
            string cmds = @"delete from NHANVIEN  where MaNV= N'" + dtonhanvien.MaNV + "'" + cmd;
            return sql.excutedata(cmds);


        }

        public DataTable timkiemnhanvien(string cmd, DTO_nhanvien dtonhanvien)
        {
            string cmds = @"select * from NHANVIEN  where TenNV like N'%" + dtonhanvien.TenNV + "'" + cmd;
            return sql.readdata(cmds);


        }

        public string gettenNV(string cmd)
        {
            
            return sql.GetDataText(cmd);


        }

        public string getchucvu(string cmd)
        {

            return sql.GetDataText(cmd);


        }
    }
}
