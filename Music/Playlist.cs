using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class Playlist
    {
        public int Id { get; set; }
        public string PlaylistName { get; set; }
        public DateTime PlaylistDate { get; set; }
        public List<UserPlaylist> UserPlaylists { get; set; }
        public List<SongPlaylist> SongPlaylists { get; set; }
    }
}
