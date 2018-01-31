using System.Collections.Generic;
using System.Linq;

using mocacore.api;
using mocacore.model;

namespace mocacore.impl
{
    class MovieInfoService : IMovieInfoService
    {

        Dictionary<string, MovieInfo> movies = new Dictionary<string, MovieInfo>()
        {
            { "GUID1", new MovieInfo {GUID = "GUID1", Name = "Star Wars", Rating = 8.3}},
                { "GUID2", new MovieInfo {GUID = "GUID2", Name = "Avengers", Rating = 7.8}},
            { "GUID3", new MovieInfo {GUID = "GUID3", Name = "The Lord of the Rings", Rating = 8.2}}
    };

        public List<MovieInfo> GetAllMoviesInfo()
        {
            return movies.Values.Select(v => v).OrderByDescending(v => v.Rating).ToList();
        }

        public MovieInfo GetMovieInfo(string guid)
        {
            MovieInfo mi = new MovieInfo();
            movies.TryGetValue(guid, out mi);
            return mi;
        }
    }
}
