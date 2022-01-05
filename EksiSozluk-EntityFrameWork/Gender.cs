using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk_EntityFrameWork
{
    public class Gender
    {
        public int genderID { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }

    }
}
