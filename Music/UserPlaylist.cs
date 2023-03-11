using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class UserPlaylist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PlaylistId { get; set; }
        public Playlist Playlist { get; set; }
    }
}
