﻿using oTTimoshenko.SocialNetwork.DataAccess.EntityFramework.Repositories.Interfaces;
using oTTimoshenko.SocialNetwork.Domain.UsersEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oTTimoshenko.SocialNetwork.DataAccess.EntityFramework.Repositories.UsersManagement
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context)
        {
            this.Context = context;
        }
    }
}
