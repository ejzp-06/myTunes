
using System;
using System.Collections.Generic;
using System.Text;
using myTunes.Core;
using myTunes.Core.Entities;

namespace myTunes.Interfaces
{
    public interface IAlbumService
    {
        ServiceResult<IEnumerable<Album>> GetAlbums();

        ServiceResult<Album> GetAlbumById(int id);

    }
}
