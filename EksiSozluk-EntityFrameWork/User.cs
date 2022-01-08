using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_EntityFrameWork
{
    public class User
    {

        public int ID { get; set; }
        public string userName { get; set; }
        public int password { get; set; }
        public List<Entry> Entries  { get; set; }

    }
}
