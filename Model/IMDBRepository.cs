using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class IMDBRepository
    {
        MongoClient client = new MongoClient("mongodb://192.168.56.101:27017");
        IMongoDatabase database;
        IMongoCollection<Persona> peopleCollection;
        IMongoCollection<Pelicula> moviesCollection;
        IMongoCollection<Oscar> oscarsCollection;

        public IMDBRepository()
        {
            database = client.GetDatabase("imdb");
            peopleCollection = database.GetCollection<Persona>("people");
            moviesCollection = database.GetCollection<Pelicula>("movies");
            oscarsCollection = database.GetCollection<Oscar>("oscars");
        }

        #region Persones
        public List<Persona> GetListaPersones()
        {
            var sort = Builders<Persona>.Sort.Ascending("name");

            //Limit 50 per a que no trigui tant el primer cop / sense filtre
            List<Persona> listaPeople = peopleCollection.Find(new BsonDocument()).Sort(sort).Limit(50).ToList();
            //List<Persona> listaPersona = new List<Persona>();

            //foreach (Persona item in listaPeople)
            //{
            //    Persona persona = new Persona();
            //    persona.id = getValue("_id", item);
            //    persona.name = getValue("name", item);
            //    persona.dob = getValue("dob", item);
            //    persona.pob = getValue("pob", item);
            //    persona.hasActed = getValue("hasActed", item);
            //    persona.hasDirected = getValue("hasDirected", item);

            //    listaPersona.Add(persona);
            //}

            return listaPeople;
        }

        public List<Persona> GetListaPersonesFiltrada(string filtre)
        {
            var filter = Builders<Persona>.Filter.Regex("name", new BsonRegularExpression(filtre));
            var sort = Builders<Persona>.Sort.Ascending("name");

            var result = peopleCollection.Find(filter).Sort(sort).ToList();

            //List<Persona> listaPersona = new List<Persona>();

            //foreach (Persona item in result)
            //{
            //    Persona persona = new Persona();
            //    persona.id = getValue("_id", item);
            //    persona.name = getValue("name", item);
            //    persona.dob = getValue("dob", item);
            //    persona.pob = getValue("pob", item);
            //    persona.hasActed = getValue("hasActed", item);
            //    persona.hasDirected = getValue("hasDirected", item);

            //    listaPersona.Add(persona);
            //}

            return result;
        }

        public void UpdatePersona(Persona p)
        {
            var filter = Builders<Persona>.Filter.Eq(s => s.id, p.id);

            if (p.hasActed == false && !CheckPersonaExistsInMoviesAndOscars(p.name))
                p.hasActed = true;
            if (p.hasDirected == false && !CheckPersonaExistsInMoviesAndOscars(p.name))
                p.hasDirected = true;

                peopleCollection.ReplaceOne(filter, p);
        }

        public void InsertPersona(Persona p)
        {
            peopleCollection.InsertOne(p);
        }

        public void EliminarPersona(string name)
        {
            if (CheckPersonaExistsInMoviesAndOscars(name))
            {
                var filter = Builders<Persona>.Filter.Eq("name", name);
                peopleCollection.DeleteOne(filter);
            }
            else
            {
                return;
            }
        }

        public bool CheckPersonaExistsInMoviesAndOscars(string name)
        {
            var result = moviesCollection.Find(x => x.actors.Any(i => i.name.Equals(name))).CountDocuments();
            result += oscarsCollection.Find(x => x.person.name.Equals(name)).CountDocuments();

            return result == 0;
        }

        public string getValue(string field, Object item)
        {

            try
            {
                return item.ToBsonDocument()[field].AsString;
            }
            catch (Exception ex)
            {
                return "-";
            }
        }
        #endregion

        #region Pelicules

        public List<Pelicula> GetPelicules()
        {
            var sort = Builders<Pelicula>.Sort.Ascending("name");

            //Limit 50 per a que no trigui tant el primer cop / sense filtre
            return moviesCollection.Find(new BsonDocument()).Sort(sort).Limit(50).ToList();
        }

        public List<Pelicula> GetPeliculesFiltered(string valorFiltre, string tipusFiltre)
        {
            switch (tipusFiltre)
            {
                case "actors":
                    return FilterMovieByActor(valorFiltre);
                    break;
                case "directors":
                    return FilterMovieByDirector(valorFiltre);
                    break;
                case "any":
                    return FilterMovieByYear(valorFiltre);
                    break;
                case "nom":
                    return FilterMovieByName(valorFiltre);
                    break;
                default:
                    return new List<Pelicula>();
                    break;

            }
        }

        private List<Pelicula> FilterMovieByDirector(string valorFiltre)
        {
            var sort = Builders<Pelicula>.Sort.Ascending("name");

            return moviesCollection.Find(x => x.directors.Any(i => i.name.ToLower().Contains(valorFiltre.ToLower()))).Sort(sort).ToList();
        }

        private List<Pelicula> FilterMovieByActor(string valorFiltre)
        {
            var sort = Builders<Pelicula>.Sort.Ascending("name");

            return moviesCollection.Find(x => x.actors.Any(i => i.name.ToLower().Contains(valorFiltre.ToLower()))).Sort(sort).ToList();
        }

        private List<Pelicula> FilterMovieByName(string valorFiltre)
        {
            var filter = Builders<Pelicula>.Filter.Regex("name", new BsonRegularExpression(valorFiltre));
            var sort = Builders<Pelicula>.Sort.Ascending("name");

            return moviesCollection.Find(filter).Sort(sort).ToList();
        }

        private List<Pelicula> FilterMovieByYear(string valorFiltre)
        {
            var filter = Builders<Pelicula>.Filter.Eq("year", valorFiltre);
            var sort = Builders<Pelicula>.Sort.Ascending("name");

            return moviesCollection.Find(filter).Sort(sort).ToList();
        }

        public List<PersonaDTO> GetActorsFromPelicula(List<Persona> actors)
        {
            var filter = Builders<Persona>.Filter.In(x => x.name, actors.Select(x => x.name));
            var sort = Builders<Persona>.Sort.Ascending("name");

            return peopleCollection.Find(filter).Sort(sort).ToList().Select(x => new PersonaDTO(x)).ToList();
        }

        public List<PersonaDTO> GetDirectorsFromPelicula(List<Persona> directors)
        {
            var filter = Builders<Persona>.Filter.In(x => x.name, directors.Select(x => x.name));
            var sort = Builders<Persona>.Sort.Ascending("name");

            return peopleCollection.Find(filter).Sort(sort).ToList().Select(x => new PersonaDTO(x)).ToList();
        }

        public List<OscarDTO> GetOscarsFromPelicula(Pelicula p)
        {
            if (p != null)
            {
                var result = oscarsCollection.Find(x => x.movie.name.Equals(p.name)).ToList().OrderBy(x => x.type).ToList();

                return result.Select(x => new OscarDTO(x)).ToList();
            }
            else
                return new List<OscarDTO>();
        }

        #endregion
    }
}
