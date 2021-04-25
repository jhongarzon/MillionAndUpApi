﻿using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public interface IUserService
    {
        User GetById(int userId);
        IEnumerable<User> GetAll();
    }
}
