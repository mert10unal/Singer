using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<SongUser> SongUsers { get; set; }
        public List<UserPlaylist> UserPlaylists { get; set; }
    }
}
