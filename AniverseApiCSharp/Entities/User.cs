using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AniverseApiCSharp.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        [JsonIgnore] // Wont return in API calls
        public byte[] PasswordHash { get; set; }

        [JsonIgnore] // Wont return in API calls
        public byte[] PasswordSalt { get; set; }
    }
}
