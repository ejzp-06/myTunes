
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myTunes.Core.Entities;
using myTunes.Interfaces;

namespace myTunes.Core.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IRepository<Album> _AlbumRepository;

        public AlbumService(IRepository<Album> AlbumRepository)
        {
            _AlbumRepository = AlbumRepository;
        }

        public ServiceResult<IEnumerable<Album>> GetAlbums()
        {
            return ServiceResult<IEnumerable<Album>>.SuccessResult(_AlbumRepository.GetAll());
        }

        public ServiceResult<Album> GetAlbumById(int id)
        {
            return ServiceResult<Album>.SuccessResult(_AlbumRepository.GetById(id));
        }

    }
}