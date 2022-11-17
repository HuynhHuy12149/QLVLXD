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
    public class BLL_nhanvien
    {
        DAL_nhanvien dalnhanvien = new DAL_nhanvien();

        public DataTable readdatanv(string cmd)
        {
            return dalnhanvien.readdatanv(cmd);
        }
        public DataTable readdatachucvu(string cmd)
        {
            return dalnhanvien.readdatachucvu(cmd);
        }

        public Boolean themnhanvien(string cmd, DTO_nhanvien dtonhanvien)
        {
            return dalnhanvien.themnhanvien(cmd, dtonhanvien);
        }

        public Boolean suanhanvien(string cmd, DTO_nhanvien dtonhanvien)
        {
            return dalnhanvien.suanhanvien(cmd, dtonhanvien);
        }

        public Boolean xoanhanvien(string cmd, DTO_nhanvien dtonhanvien)
        {
            return dalnhanvien.xoanhanvien(cmd, dtonhanvien);
        }

        public DataTable timkiemnhanvien(string cmd, DTO_nhanvien dtonhanvien)
        {
            return dalnhanvien.timkiemnhanvien(cmd, dtonhanvien);
        }

        public string gettenNV(string cmd)
        {

            return dalnhanvien.gettenNV(cmd);


        }

        public string getchucvu(string cmd)
        {

            return dalnhanvien.getchucvu(cmd);


        }
    }
}
