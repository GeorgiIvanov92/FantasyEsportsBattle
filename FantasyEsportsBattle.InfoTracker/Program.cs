﻿using System;
using System.IO;
using System.Linq;
using FantasyEsportsBattle.InfoTracker.Sites;
using FantasyEsportsBattle.Web.Constants;
using FantasyEsportsBattle.Web.Data;
using FantasyEsportsBattle.Web.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace FantasyEsportsBattle.InfoTracker
{
    class Program
    {
        private static readonly TimeSpan _workerBreakTime = TimeSpan.FromMinutes(30);
        private static readonly CompetitionsService competitionsService = new CompetitionsService();
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            BuildConfig(builder);

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.File(@"log/logErrors.txt", rollingInterval: RollingInterval.Day, fileSizeLimitBytes: 2000_0000, retainedFileCountLimit: 20)
                .CreateLogger();

            var configuration = builder.Build();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            var context = new ApplicationDbContext(optionsBuilder.Options);

            var defaultImg = context.Images.FirstOrDefault(i => i.Id == Constants.DefaultImageId);
            if (defaultImg == null)
            {
                var img = new Host.Data.Models.Image
                {
                    ImageTitle = "DefaultImage"
                };

                img.ImageData = File.ReadAllBytes("default.png");
                context.Images.Add(img);
                context.SaveChanges();
            }
            else if (defaultImg.ImageData == null)
            {
                
                defaultImg.ImageData = File.ReadAllBytes("default.png");
                context.SaveChanges();
            }

            StartTrackers(context, competitionsService);
        }

        private static void StartTrackers(ApplicationDbContext dbContext, CompetitionsService competitionsService)
        {
            GamesOfLegends gol = new GamesOfLegends();

            gol.ParseWebsiteOnInterval(dbContext, _workerBreakTime, competitionsService);
        }

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile(
                    $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables();
        }
    }
}
