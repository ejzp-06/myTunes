using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myTunes.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public int points { get; set; }

        public DateTime LaunchDate { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public int Price { get; set; }

        public Song Songs { get; set; }
    }
}
