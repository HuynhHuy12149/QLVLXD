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
    public class DAL_hanghoa
    {
        sql_grud sql = new sql_grud();

        public DataTable readdataHH(string cmd)
        {
            string cmds = "select * from SanPham" + cmd;
            return sql.readdata(cmds);
        }
        public DataTable readdataNCC(string cmd)
        {
            string cmds = "select * from NHACUNGCAP" + cmd;
            return sql.readdata(cmds);
        }

        public DataTable readdataNhom(string cmd)
        {
            string cmds = "select * from NHOMSANPHAM" + cmd;
            return sql.readdata(cmds);
        }
        public Boolean them(string cmd, DTO_hanghoa dtohanghoa)
        {
            string cmds = @"INSERT INTO SANPHAM (MaSP,MaNhom,TenSP,DonViTinh,SLTon,GiaBan,GiaNhap,MaNCC) VALUES (N'" + dtohanghoa.MaSP + "',N'" + dtohanghoa.MaNhom + "',N'" + dtohanghoa.TenSP + "',N'" + dtohanghoa.DonViTinh + "'," + dtohanghoa.SLTon + "," + dtohanghoa.GiaBan + "," + dtohanghoa.GiaNhap + ",N'" + dtohanghoa.MaNCC + "')" + cmd;
            return sql.excutedata(cmds);


        }

        public Boolean sua(string cmd, DTO_hanghoa dtohanghoa)
        {
            string cmds = @"UPDATE SANPHAM SET MaNhom = N'" + dtohanghoa.MaNhom + "',TenSP = N'" + dtohanghoa.TenSP + "',DonViTinh = N'" + dtohanghoa.DonViTinh + "',SLTon = " + dtohanghoa.SLTon + ",GiaBan =  " + dtohanghoa.GiaBan + ",GiaNhap = " + dtohanghoa.GiaNhap + ",MaNCC=N'" + dtohanghoa.MaNCC + "' WHERE MaSP= N'" + dtohanghoa.MaSP + "'" + cmd;
            return sql.excutedata(cmds);


        }

        public Boolean xoa(string cmd, DTO_hanghoa dtohanghoa)
        {
            string cmds = @"delete from SANPHAM  where MaSP= N'" + dtohanghoa.MaSP + "'" + cmd;
            return sql.excutedata(cmds);


        }

        public DataTable timkiem(string cmd, DTO_hanghoa dtohanghoa)
        {
            string cmds = @"select * from SANPHAM  where TenSP like N'%" + dtohanghoa.TenSP + "'" + cmd;
            return sql.readdata(cmds);


        }
    }
}
