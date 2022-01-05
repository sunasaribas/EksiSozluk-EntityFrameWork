using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_EntityFrameWork
{
    public class User
    {

        public int userID { get; set; }
        public string userName { get; set; }
        public string eMail { get; set; }
        public int password { get; set; }
        public DateTime birtDay { get; set; }
        public string gender { get; set; }

    }
}
