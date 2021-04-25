using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using MillionAndUp.Data;
using MillionAndUp.Domain.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly MillionUpDbContext _context;
        private readonly AppSettings _appSettings;
        public UserService(IOptions<AppSettings> appSettings)
        {
            _context = new MillionUpDbContext();
            _appSettings = appSettings.Value;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _context.Users.SingleOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            return new AuthenticateResponse(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(int userId)
        {
            return _context.Users.Find(userId);
        }
    }
}
