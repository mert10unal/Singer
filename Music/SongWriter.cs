

using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class SongWriter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Song> Songs { get; set; }
    }
}
