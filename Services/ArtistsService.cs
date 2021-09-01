using System;
using System.Collections.Generic;
using Artsy.Data;
using Artsy.Models;

namespace Artsy.Services
{
    public class ArtistsService
    {
        private readonly ArtistsRepository _artistsRepo;

        public ArtistsService(ArtistsRepository artistsRepo)
        {
            _artistsRepo = artistsRepo;
        }

        public List<Artist> GetAll()
        {
            return _artistsRepo.GetAll();
        }

        public Artist CreateArtist(Artist artistData)
        {
            return _artistsRepo.Create(artistData);
        }
    }
}