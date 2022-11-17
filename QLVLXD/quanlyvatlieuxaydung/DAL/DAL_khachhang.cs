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
    public class DAL_khachhang
    {
        sql_grud sql = new sql_grud();

        public DataTable readdataKH(string cmd)
        {
            string cmds = "select * from KHACHHANG" + cmd;
            return sql.readdata(cmds);
        }

        public Boolean them(string cmd, DTO_khachhang dtokhachhang)
        {
            string cmds = @"INSERT INTO KHACHHANG (MaKH,TenKH,DiaChiKH,SDTKH) VALUES (N'" + dtokhachhang.MaKH + "',N'" + dtokhachhang.TenKH + "',N'" + dtokhachhang.DiaChiKH + "',N'" + dtokhachhang.SDTKH + "')" + cmd;
            return sql.excutedata(cmds);


        }

        public bool sua(string cmd, DTO_khachhang dtokhachhang)
        {
            string cmds = @"update KHACHHANG SET  TenKH = N'" + dtokhachhang.TenKH + "', DiaChiKH = N'" + dtokhachhang.DiaChiKH + "',SDTKH ='" + dtokhachhang.SDTKH + "' where MaKH = N'"+dtokhachhang.MaKH+"'"+ cmd;
            return sql.excutedata(cmds);


        }

        public Boolean xoa(string cmd, DTO_khachhang dtokhachhang)
        {
            string cmds = @"delete from KHACHHANG  where MaKH= N'" + dtokhachhang.MaKH + "'" + cmd;
            return sql.excutedata(cmds);


        }

        public DataTable timkiem(string cmd, DTO_khachhang dtokhachhang)
        {
            string cmds = @"select * from KHACHHANG  where TenKH like N'%" + dtokhachhang.TenKH + "' or TenKH like N'%"+dtokhachhang.TenKH+ "' or MaKH like '%" + dtokhachhang.MaKH + "%'  or DiaChiKH like N'%" + dtokhachhang.DiaChiKH + "%' or DiaChiKH like N'%" + dtokhachhang.DiaChiKH + "' or SDTKH like '%" + dtokhachhang.SDTKH + "%' " + cmd;
            return sql.readdata(cmds);


        }

        public DataTable timkiemsql(string cmdsql)
        {
              return sql.readdata(cmdsql);
        }
        public Boolean sqlundoadd(string cmd)
        {
            return sql.excutedata(cmd);
        }

        public Boolean sqlundoedit(string cmd)
        {
            return sql.excutedata(cmd);
        }
        public Boolean sqlundodelete(string cmd)
        {
            return sql.excutedata(cmd);
        }

        public DataTable GetData(string Condition)
        {
            return sql.readdata( @"Select * from KHACHHANG " + Condition);
        }
        public Boolean adddataimport(string cmd,DTO_khachhang dtokhachhang)
        {
            string cmds = @"INSERT INTO KHACHHANG (MaKH,TenKH,DiaChiKH,SDTKH) VALUES (N'" + dtokhachhang.MaKH + "',N'" + dtokhachhang.TenKH + "',N'" + dtokhachhang.DiaChiKH +"',N'"+dtokhachhang.SDTKH+"')" +cmd;
            return sql.excutedata(cmds);
        }
    }
}
