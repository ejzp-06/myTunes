using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTunes.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int Duration { get; set; }

        public int Popularity { get; set; }

        public int Price { get; set; }
    }
}
