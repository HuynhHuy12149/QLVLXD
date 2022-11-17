using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_khachhang
    {
        DAL_khachhang dalkhachhang = new DAL_khachhang();

        public DataTable readdataKH(string cmd)
        {
            return dalkhachhang.readdataKH(cmd);
        }

        public Boolean them(string cmd, DTO_khachhang dtokhachhang)
        {
            return dalkhachhang.them(cmd, dtokhachhang);
        }

        public bool sua(string cmd, DTO_khachhang dtokhachhang)
        {
            return dalkhachhang.sua(cmd, dtokhachhang);
        }

        public Boolean xoa(string cmd, DTO_khachhang dtokhachhang)
        {
            return dalkhachhang.xoa(cmd, dtokhachhang);
        }

        public DataTable timkiem(string cmd, DTO_khachhang dtokhachhang)
        {
            return dalkhachhang.timkiem(cmd, dtokhachhang);
        }

        public DataTable timkiemsql(string cmdsql)
        {
            return dalkhachhang.timkiemsql(cmdsql);
        }
        public Boolean sqlundoadd(string cmd)
        {
            return dalkhachhang.sqlundoadd(cmd);
        }
        public Boolean sqlundoedit(string cmd)
        {
            return dalkhachhang.sqlundoedit(cmd);
        }

        public Boolean sqlundodelete(string cmd)
        {
            return dalkhachhang.sqlundoedit(cmd);
        }

        public DataTable GetData(string Condition)
        {
            return dalkhachhang.GetData(Condition);
        }
        public Boolean adddataimport(string cmd, DTO_khachhang dtokhachhang)
        {
            return dalkhachhang.adddataimport(cmd,dtokhachhang);
        }
    }
}
