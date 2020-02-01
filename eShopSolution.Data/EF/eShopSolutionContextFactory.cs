using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eShopSolution.Data.EF
{
    public class EShopSolutionContextFactory : IDesignTimeDbContextFactory<EShopSolutionDbContext>
    {
        public EShopSolutionDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()

                .SetBasePath(Directory.GetCurrentDirectory())

                .AddJsonFile("app-settings.json").Build();
            var connectionString = configuration.GetConnectionString("eShopSolutionDb");
            var optionsBuilder = new DbContextOptionsBuilder<EShopSolutionDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EShopSolutionDbContext(optionsBuilder.Options);
        }
    }
}
