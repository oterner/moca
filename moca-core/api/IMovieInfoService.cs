using System.Collections.Generic;

using mocacore.model;

namespace mocacore.api
{
    interface IMovieInfoService
    {
        MovieInfo GetMovieInfo(string guid);
        List<MovieInfo> GetAllMoviesInfo();
    }
}
