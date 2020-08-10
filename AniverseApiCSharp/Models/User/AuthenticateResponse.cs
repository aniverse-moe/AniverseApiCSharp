using AniverseApiCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AniverseApiCSharp.Models.User
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(UserResponse user, string token)
        {
            Id = user.Id;
            Username = user.Username;
            Token = token;
        }
    }
}
