using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class Song
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string Genre { get; set; }
        public List<SongSinger> SongSingers { get; set; }
        public List<SongUser> SongUsers { get; set; }
        public int ComposerId { get; set; }
        public Composer Composer { get; set; }
        public int SongWriterId { get; set; }
        public SongWriter SongWriter { get; set; }
    }
}
