using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.database.entities;

namespace DatingApp.API.Services
{
    public interface ITokenService
    {
        public string CreateToken(User user);
        
    }
}