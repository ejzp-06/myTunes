using System;
using System.Collections.Generic;
using System.Text;

namespace myTunes.Core.Entities
{
    public class Album
    {
        public Album()
        {
            Songs = new List<Song>();
        }
        public ICollection<Song> Songs { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public int points { get; set; }

        public DateTime LaunchDate { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int Price { get; set; }
    }
}
