using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WebsiteAddress { get; set; }
        public string Type { get; set; }
        public List<SongSinger> SongSingers { get; set; }
    }
}
