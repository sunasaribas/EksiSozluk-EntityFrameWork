using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_EntityFrameWork
{
    public class Debe
    {
        public int ID { get; set; }
        public string Entries { get; set; }
        public int userID { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
    }
}
