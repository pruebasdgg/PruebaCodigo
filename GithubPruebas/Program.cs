﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GithubPruebas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run(); // Hola mundo
            //Y de nuevo otro comentario
        }
//Y otra vez otro comentario pero esta vez desde sourcesafe
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
