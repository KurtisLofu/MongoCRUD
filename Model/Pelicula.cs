using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [BsonIgnoreExtraElements]
    public class Pelicula
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public int runtime { get; set; }
        public List<Persona> actors { get; set; }
        public List<Persona> directors { get; set; }
        public List<Oscar> oscars { get; set; }

        public Pelicula(string id, string name, int year, int runtime, List<Persona> actors, List<Persona> directors, List<Oscar> oscars)
        {
            this.id = id;
            this.name = name;
            this.year = year;
            this.runtime = runtime;
            this.actors = actors;
            this.directors = directors;
            this.oscars = oscars;
        }
    }
}
