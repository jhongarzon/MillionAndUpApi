﻿using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly MillionUpDbContext _context;
        public UserService()
        {
            _context = new MillionUpDbContext();
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
