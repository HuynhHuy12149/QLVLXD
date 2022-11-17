using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LOGIN
    {
        public string MaNV { get; set; }
        public string TenDN { get; set; }
        public string PassDN { get; set; }
        public string MaChucVu { get; set; }
        public DTO_LOGIN()
        {

        }
        
        public DTO_LOGIN(string MaNV, string PassDN)
        {
            this.MaNV = MaNV;
            this.PassDN = PassDN;
            
        }
        public DTO_LOGIN(string MaNV, string PassDN, string MaChucVu)
        {
            this.MaNV = MaNV;
            this.PassDN = PassDN;
            this.MaChucVu = MaChucVu;
        }

    }
}
