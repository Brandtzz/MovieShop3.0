using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MovieStoreDAL
{

    public class MovieRepository : IRepository<Movie>
    {
        private MovieStoreDbContext db = new MovieStoreDbContext();



        public void Add(Movie entity)
        {
            using (var db = new MovieStoreDbContext())
            {
                db.Movies.Add(entity);
                db.SaveChanges();
            }
        }


        public Movie Edit(Movie entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
            return entity;
        }

        public Movie Get(int id)
        {
            
            return db.Movies.AsNoTracking().FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            using (var db = new MovieStoreDbContext())
            {
                IEnumerable<Movie> movie = db.Movies.AsNoTracking().ToList();
                
                return movie;
            }
        }

        public Movie Remove(int id)
        {

            Movie movie = db.Movies.FirstOrDefault(a => a.Id == id);
        
            db.Movies.Remove(movie);
            db.SaveChanges();
            return movie;

        }

        
    }
}
