
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using myTunes.Core.Entities;
using myTunes.Interfaces;

namespace myTunes.Core.Services
{
    public class SongService : ISongService
    {
        private readonly IRepository<Song> _songRepository;

        public SongService(IRepository<Song> SongRepository)
        {
            _songRepository = SongRepository;
        }

        public ServiceResult<IEnumerable<Song>> GetSongs()
        {
            return ServiceResult<IEnumerable<Song>>.SuccessResult(_songRepository.GetAll());
        }

    }
}