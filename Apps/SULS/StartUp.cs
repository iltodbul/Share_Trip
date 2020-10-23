﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SULS.Data;
using SULS.Services;
using SUS.HTTP;
using SUS.MvcFramework;

namespace SULS
{
    public class StartUp :IMvcApplication
    {
        public void Configure(List<Route> routeTable)
        {
            new SULSContext().Database.Migrate();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.Add<IUsersService, UsersService>();
        }

    }
}