using System;
using System.Collections.Generic;

using mocacore.model;
using mocacore.api;
using mocacore.impl;

namespace mocacore
{

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
