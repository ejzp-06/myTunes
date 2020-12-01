
using System;
using System.Collections.Generic;
using System.Text;
using myTunes.Core;
using myTunes.Core.Entities;

namespace myTunes.Interfaces
{
    public interface ISongService
    {
        ServiceResult<IEnumerable<Song>> GetSongs();

    }
}
