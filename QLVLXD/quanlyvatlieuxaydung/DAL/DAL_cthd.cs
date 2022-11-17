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
    public class DAL_cthd
    {
        sql_grud sql = new sql_grud();

        public DataTable readdatadgcthd(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"select * from CHITIETHDBAN where MaHD = N'"+dtocthd.MaHD+"' " + cmd;
            return sql.readdata(cmds);
        }

        public DataTable readdatadgcthdchangecb(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"select * from CHITIETHDBAN where MaHD = N'"+dtocthd.MaHD+"'" + cmd;
            return sql.readdata(cmds);
        }
        public DataTable readdatasp(string cmd)
        {
            string cmds = @"select * from SANPHAM" + cmd;
            return sql.readdata(cmds);
        }

        public DataTable readdatahd(string cmd)
        {
            string cmds = "select * from HOADONBAN" + cmd;
            return sql.readdata(cmds);
        }
        public Boolean them(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"INSERT INTO CHITIETHDBAN (MaHD,MaSP, SLBan,DonGiaBan, ThanhTienBan) VALUES (N'" + dtocthd.MaHD + "',N'" + dtocthd.MaSP + "'," + dtocthd.SLBan + "," + dtocthd.DonGiaBan + "," + dtocthd.ThanhTienBan + ")" + cmd;
            return sql.excutedata(cmds);


        }

        public Boolean sua(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"UPDATE CHITIETHDBAN SET MaHD= N'" + dtocthd.MaHD + "',MaSP = N'" + dtocthd.MaSP + "',SLBan = " + dtocthd.SLBan + ",DonGiaBan = " + dtocthd.DonGiaBan + ",ThanhTienBan = " + dtocthd.ThanhTienBan + " where MaHD = N'" + dtocthd.MaHD + "'" + cmd;
            return sql.excutedata(cmds);


        }
        public Boolean xoa(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"delete from CHITIETHDBAN where MaSP= N'" + dtocthd.MaSP + "'" + cmd;
            return sql.excutedata(cmds);


        }
        public Boolean tongtienhoadon(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"UPDATE CHITIETHDBAN SET SLBan='" + dtocthd.SLBan + "' where MaHD = N'" + dtocthd.MaHD + "'" + cmd;
            return sql.excutedata(cmds);


        }

        public string Gettongtienhoadon(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"select TongTienBan from HOADONBAN where MaHD = N'" + dtocthd.MaHD + "'" + cmd;
            return sql.GetDataText(cmds);


        }

        public Boolean updatetongtienhoadon(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"update HOADONBAN set TongTienBan = (select sum(ThanhTienBan) from CHITIETHDBAN where MaHD = '" + dtocthd.MaHD + "') where MaHD = '" + dtocthd.MaHD + "'" + cmd;
            return sql.excutedata(cmds);


        }
        public DataTable readdatamanv(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"select MaNV from HoaDonBan where MaHD = N'" + dtocthd.MaHD + "'" + cmd;
            return sql.readdata(cmds);


        }

        public string Gettennv(string cmd, DTO_nhanvien dtonhanvien)
        {
            string cmds = @"select TenNV from NHANVIEN where MaNV = N'" + dtonhanvien.MaNV + "'" + cmd;
            return sql.GetDataText(cmds);


        }

        public DataTable readdatamakh(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"select MaKH from HoaDonBan where MaHD = N'" + dtocthd.MaHD + "'" + cmd;
            return sql.readdata(cmds);


        }

        public string Gettenkh(string cmd, DTO_khachhang dtokh)
        {
            string cmds = @"select TenKH from KHACHHANG where MaKH = N'" + dtokh.MaKH + "'" + cmd;
            return sql.GetDataText(cmds);


        }




        public string Getngayban(string cmd, DTO_cthd dtocthd)
        {
            string cmds = @"select NgayBan from HOADONBAN where MaHD = N'" + dtocthd.MaHD + "'" + cmd;
            return sql.GetDataText(cmds);


        }
        public string Getdiachikh(string cmd, DTO_khachhang dtokh)
        {
            string cmds = @"select DiaChiKH from KHACHHANG where MaKH = N'" + dtokh.MaKH + "'" + cmd;
            return sql.GetDataText(cmds);


        }
        public string Getsdtkh(string cmd, DTO_khachhang dtokh)
        {
            string cmds = @"select SDTKH from KHACHHANG where MaKH = N'" + dtokh.MaKH + "'" + cmd;
            return sql.GetDataText(cmds);


        }

        public string Getdongia(string cmd, DTO_hanghoa dtohanghoa)
        {
            string cmds = @"select GiaBan from SANPHAM where MaSP = N'" + dtohanghoa.MaSP + "'" + cmd;
            return sql.GetDataText(cmds);


        }

        public string Getsoluongkho(string cmd, DTO_hanghoa dtohanghoa)
        {
            string cmds = @"select SLTon from SANPHAM where MaSP = N'" + dtohanghoa.MaSP + "'" + cmd;
            return sql.GetDataText(cmds);


        }
    }
}
