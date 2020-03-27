﻿using API.DAL;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IUserService
    {
        Task<AppUser> GetByEmail(string email);
        Task<AppUser> GetById(string id);
        Task<bool> CreateUser(AppUser appUser, string hashedPassword);
    }
}