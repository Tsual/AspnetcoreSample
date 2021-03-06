﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BackendSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder=CreateWebHostBuilder(args).UseDefaultServiceProvider(cfg =>
            {
                cfg.ValidateScopes = false;
            });
            builder.Build();
            builder.Start();

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
