using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_EntityFrameWork
{
    public class Categories
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Entry> Entries { get; set; }
    }
}
