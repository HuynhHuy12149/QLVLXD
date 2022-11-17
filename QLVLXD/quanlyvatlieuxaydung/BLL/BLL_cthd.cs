using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_cthd
    {
        DAL_cthd dalcthd = new DAL_cthd();

        public DataTable readdatadgcthd(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.readdatadgcthd(cmd, dtocthd);
        }

        public DataTable readdatadgcthdchangecb(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.readdatadgcthdchangecb(cmd,dtocthd);
        }
        public DataTable readdatasp(string cmd)
        {
            return dalcthd.readdatasp(cmd);
        }

        public DataTable readdatahd(string cmd)
        {
            return dalcthd.readdatahd(cmd);
        }
        public Boolean them(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.them(cmd, dtocthd);
        }

        public Boolean sua(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.sua(cmd, dtocthd);
        }

        public Boolean xoa(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.xoa(cmd, dtocthd);
        }

        public Boolean updatetongtienhoadon(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.updatetongtienhoadon(cmd, dtocthd);
        }

        public string Gettongtienhoadon(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.Gettongtienhoadon(cmd, dtocthd);
        }

        public DataTable readdatamanv(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.readdatamanv(cmd, dtocthd);
        }

        public string Gettennv(string cmd, DTO_nhanvien dtonv)
        {
            return dalcthd.Gettennv(cmd, dtonv);
        }

        public DataTable readdatamakh(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.readdatamakh(cmd, dtocthd);
        }

        public string Gettenkh(string cmd, DTO_khachhang dtokh)
        {
            return dalcthd.Gettenkh(cmd, dtokh);
        }

        public string Getngayban(string cmd, DTO_cthd dtocthd)
        {
            return dalcthd.Getngayban(cmd, dtocthd);
        }

        public string Getdiachikh(string cmd, DTO_khachhang dtokh)
        {
            return dalcthd.Getdiachikh(cmd, dtokh);
        }
        public string Getsdtkh(string cmd, DTO_khachhang dtokh)
        {
            return dalcthd.Getsdtkh(cmd, dtokh);
        }

        public string Getdongia(string cmd, DTO_hanghoa dtohanghoa)
        {
            return dalcthd.Getdongia(cmd, dtohanghoa);
        }

        public string Getsoluongkho(string cmd, DTO_hanghoa dtohanghoa)
        {
            return dalcthd.Getsoluongkho(cmd, dtohanghoa);
        }
    }
}
