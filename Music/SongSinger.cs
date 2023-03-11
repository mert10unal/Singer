using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class SongSinger
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
        public int SingerId { get; set; }
        public Singer Singer { get; set; }
    }
}
