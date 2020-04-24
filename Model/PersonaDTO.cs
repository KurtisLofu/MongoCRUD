using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class PersonaDTO
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pob { get; set; }
        public string dob { get; set; }

        public PersonaDTO(Persona p)
        {
            id = p.id;
            name = p.name;
            pob = p.pob;
            dob = p.dob;
        }
    }
}
