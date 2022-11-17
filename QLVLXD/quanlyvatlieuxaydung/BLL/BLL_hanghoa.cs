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
    public class BLL_hanghoa
    {
        DAL_hanghoa dalhanghoa = new DAL_hanghoa();

        public DataTable readdataHH(string cmd)
        {
            return dalhanghoa.readdataHH(cmd);
        }
        public DataTable readdataNCC(string cmd)
        {
            return dalhanghoa.readdataNCC(cmd);
        }

        public DataTable readdataNhom(string cmd)
        {
            return dalhanghoa.readdataNhom(cmd);
        }
        public Boolean them(string cmd, DTO_hanghoa dtohanghoa)
        {
            return dalhanghoa.them(cmd, dtohanghoa);
        }

        public Boolean sua(string cmd, DTO_hanghoa dtohanghoa)
        {
            return dalhanghoa.sua(cmd, dtohanghoa);
        }

        public Boolean xoa(string cmd, DTO_hanghoa dtohanghoa)
        {
            return dalhanghoa.xoa(cmd, dtohanghoa);
        }

        public DataTable timkiem(string cmd, DTO_hanghoa dtohanghoa)
        {
            return dalhanghoa.timkiem(cmd, dtohanghoa);
        }
    }
}
