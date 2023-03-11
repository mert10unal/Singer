using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class SongUser
    {
        public int Id { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
