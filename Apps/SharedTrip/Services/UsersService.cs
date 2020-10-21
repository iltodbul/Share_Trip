﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using SharedTrip.Data;
using SharedTrip.Models;

namespace SharedTrip.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext dbContext;

        public UsersService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public void Create(string username, string email, string password)
        {
            var user = new User()
            {
                Email = email,
                Password = ComputeHash(password),
                Username = username,
            };

            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public string GetUserId(string username, string password)
        {
            var hashPassword = ComputeHash(password);

            var user = dbContext.Users.FirstOrDefault(x => x.Username == username && x.Password == hashPassword);

            return user?.Id;
        }

        public bool IsEmailAvailable(string email)
        {
            return !dbContext.Users.Any(x => x.Email == email);
        }

        public bool IsUsernameAvailable(string username)
        {
            return !dbContext.Users.Any(x => x.Username == username);
        }


        private static string ComputeHash(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            using var hash = SHA512.Create();
            var hashedInputBytes = hash.ComputeHash(bytes);
            // Convert to text
            // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
            var hashedInputStringBuilder = new StringBuilder(128);
            foreach (var b in hashedInputBytes)
                hashedInputStringBuilder.Append(b.ToString("X2"));
            return hashedInputStringBuilder.ToString();
        }
    }
}
