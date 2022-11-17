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
    public class BLL_LOGIN
    {
        DTO_LOGIN LG = new DTO_LOGIN();
        DAL_LOGIN dal_login = new DAL_LOGIN();
        public DataTable readdata(string cmd, DTO_LOGIN LG)
        {
            return dal_login.readdata(cmd, LG);
        }

        public bool readdatachange(string cmd, DTO_LOGIN LG)
        {
            return dal_login.readdatachange(cmd, LG);
        }

        public bool changedatapass(string cmd, DTO_LOGIN LG1)
        {
            return dal_login.changedatapass(cmd, LG1);
        }
        public DataTable readdatachucvu(string cmd)
        {
            return dal_login.readdatachucvu(cmd);
        }
    }
}
