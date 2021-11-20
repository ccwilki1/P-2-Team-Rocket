using System;
using System.IO;
using BL;
using DL;
using DL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UI;
namespace UI
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();
            DbContextOptions<P3ApiContext> options = new DbContextOptionsBuilder<P3ApiContext>()
                .UseSqlServer(config.GetConnectionString("ReferenceToDB"))
                .Options;
            
            Console.WriteLine("Hello World!");

            var instance = new ConsoleTesting(new UsersBL(new UserCloudRepo(new P3ApiContext(options))));
            //instance.TestAdd();
            Console.WriteLine(instance.TestShowAll());
            
        }

        
    }
}
