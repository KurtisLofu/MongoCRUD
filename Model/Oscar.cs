using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [BsonIgnoreExtraElements]
    public class Oscar
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public Persona person { get; set; }
        public Pelicula movie { get; set; }

        public Oscar(string id, int year, string type, Persona persona, Pelicula pelicula)
        {
            this.id = id;
            this.year = year;
            this.type = type;
            this.person = persona;
            this.movie = pelicula;
        }
    }
}
