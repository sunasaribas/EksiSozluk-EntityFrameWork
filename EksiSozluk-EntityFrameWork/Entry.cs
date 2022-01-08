using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_EntityFrameWork
{
    public class Entry
    {
        public int EntryID { get; set; }

        public int UserID { get; set; }

        public string Comment { get; set; }
        public DateTime CommentTime { get; set; }

        public int CatID { get; set; }

        public Categories Categories { get; set; } 

        public User User { get; set; }

    }
}
