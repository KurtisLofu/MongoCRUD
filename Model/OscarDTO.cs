using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OscarDTO
    {
        public string id { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public string person { get; set; }

        public OscarDTO(Oscar oscar)
        {
            this.id = oscar.id;
            this.year = oscar.year;
            this.type = oscar.type;
            this.person = oscar.person.name;
        }
    }
}
