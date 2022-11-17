
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class writelogactivities
    {
        public void WriteLog(string user = "", string table = "", string action = "", string nameObjectAction = "")
        {
            string path = @"LogFile.txt";
            
            System.IO.File.AppendAllText(path, DateTime.Now.ToString() + "\t" + user + "\t" + table + "\t" + action + "\t" + nameObjectAction + Environment.NewLine);
            
        }
    }
   
}
