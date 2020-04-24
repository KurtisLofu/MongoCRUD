using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [BsonIgnoreExtraElements]
    public class Persona
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }
        public string name { get; set; }
        public string pob { get; set; }
        public string dob { get; set; }
        public bool hasActed { get; set; }
        public bool hasDirected { get; set; }

        public Persona()
        {

        }

        public Persona(string id, string nom, string llocNaixement, string dataNaixement, bool hasActed, bool hasDirected)
        {
            this.id = id;
            this.name = nom;
            this.pob = llocNaixement;
            this.dob = dataNaixement;
            this.hasActed = hasActed;
            this.hasDirected = hasDirected;
        }
    }
}
