using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_hoadon
    {
        DAL_hoadon dalhoadon = new DAL_hoadon();

        public DataTable readdatadg(string cmd)
        {
            return dalhoadon.readdatadg(cmd);
        }
        public DataTable readdataKH(string cmd)
        {
            return dalhoadon.readdataKH(cmd);
        }

        public DataTable readdataNV(string cmd)
        {
            return dalhoadon.readdataNV(cmd);
        }
        public Boolean them(string cmd, DTO_hoadon dtohoadon)
        {
            return dalhoadon.them(cmd, dtohoadon);
        }

        public Boolean sua(string cmd, DTO_hoadon dtohoadon)
        {
            return dalhoadon.sua(cmd, dtohoadon);
        }

        public Boolean xoa(string cmd, DTO_hoadon dtohoadon)
        {
            return dalhoadon.xoa(cmd, dtohoadon);
        }

        public DataTable timkiem(string cmd, DTO_hoadon dtohoadon)
        {
            return dalhoadon.timkiem(cmd, dtohoadon);
        }

    }
}
