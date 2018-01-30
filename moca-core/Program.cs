using System;
using System.Collections.Generic;
using System.Linq;

namespace mocacore
{
    class MovieInfo
    {
        public string GUID { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
    }

    interface IMovieInfoService
    {
        MovieInfo GetMovieInfo(string guid);
        List<MovieInfo> GetAllMoviesInfo();
    }

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
            return movies.Values.Select(v => v).ToList();
        }

        public MovieInfo GetMovieInfo(string guid)
        {
            MovieInfo mi = new MovieInfo();
            movies.TryGetValue(guid, out mi);
            return mi;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            IMovieInfoService mis = new MovieInfoService();
            MovieInfo mi = mis.GetMovieInfo("GUID3");

            Console.WriteLine(mi.Name);
            Console.WriteLine("**********************");

            List<MovieInfo> infos = mis.GetAllMoviesInfo();
            infos.ForEach(
                i => Console.WriteLine(i.Name)
            );

            Console.WriteLine("**********************");
        }
    }
}
