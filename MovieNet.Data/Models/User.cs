using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNet.Data.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DatedJoined { get; set; }
    }
}
