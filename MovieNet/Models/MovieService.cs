using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MovieNet.Models
{
    public class MovieService
    {
        MovieNetdbEntities ObjContext;

            public MovieService()
            {
            ObjContext = new MovieNetdbEntities();

            }

        public List<MovieDTO> GetAll()
        {
            List<MovieDTO> ObjMoviesList = new List<MovieDTO>();
            try 
            {
                var ObjQuery = from Movie in ObjContext.Movies
                               select Movie;
                foreach(var Movie in ObjQuery)
                {
                    ObjMoviesList.Add(new MovieDTO
                    {
                        Id = Movie.Id, 
                        Titre = Movie.Title,
                        Resume = Movie.Resume,
                        Genre = Movie.Genre
                    });
                }
             
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
             
            }
            return ObjMoviesList;
        }

        public bool Add(MovieDTO objNewMovie)
        {
            bool IsAdded = false;
            try
            {
                var ObjMovie = new Movie();
                ObjMovie.Id = objNewMovie.Id;
                ObjMovie.Title = objNewMovie.Titre;
                ObjMovie.Resume = objNewMovie.Resume;
                ObjMovie.Genre = objNewMovie.Genre;

                ObjContext.Movies.Add(ObjMovie);
                var NoOfRowsAffected = ObjContext.SaveChanges();
                IsAdded = NoOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return IsAdded;
        }

        public bool Update(MovieDTO objMovieToUpdate)
        {
            bool IsUpdated = false;
           
            try
            {
                var ObjMovie = ObjContext.Movies.Find(objMovieToUpdate.Id);
                ObjMovie.Title = objMovieToUpdate.Titre;
                ObjMovie.Resume = objMovieToUpdate.Resume;
                ObjMovie.Genre = objMovieToUpdate.Genre;
                var NoOfRowsAffected = ObjContext.SaveChanges();
                IsUpdated = NoOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return IsUpdated;
        }

        public bool Delete(int id)
        {
            bool IsDeleted = false;
           try
            {
                var ObjMovieToDelete = ObjContext.Movies.Find(id);
                ObjContext.Movies.Remove(ObjMovieToDelete);
                var NoOfRowsAffected = ObjContext.SaveChanges();
                IsDeleted = NoOfRowsAffected > 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return IsDeleted;
        }

        public MovieDTO search(int id)
        {
            MovieDTO ObjMovie = null;

            try
            {
                var ObjMovieToFind = ObjContext.Movies.Find(id);
                if(ObjMovieToFind != null)
                {
                    ObjMovie = new MovieDTO()
                    {
                        Id = ObjMovieToFind.Id,
                        Titre = ObjMovieToFind.Title,
                        Resume = ObjMovieToFind.Resume,
                        Genre = ObjMovieToFind.Genre,
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ObjMovie;
        }
    }
}
