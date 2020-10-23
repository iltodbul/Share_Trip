﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SULS.Services
{
    public interface IUsersService
    {
        void Create(string username, string email, string password);


        string GetUserId(string username, string password);

        bool IsUsernameAvailable(string username);

        bool IsEmailAvailable(string email);
    }
}
