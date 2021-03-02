using Contracts;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineShop_ASP_Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities {
    public static class MigrationManager {
        //private static readonly NLog.Logger _logger = NLog.LogManager.GetLogger(typeof(LoggerManager).FullName);

        /// <summary>
        /// Extension method for creating and starting all the migrations at the application startup
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public static IHost MigrateDatabase(this IHost host) {
            using (var scope = host.Services.CreateScope()) {
                using (var appContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>()) {
                    try {
                        appContext.Database.Migrate();
                    } catch (Exception e) {
                        // TODO: Create log from ILoggerManager
                        //_logger.LogError("ERROR: " + e.Message);
                        throw;
                    }
                }
            }

            return host;
        }

    }
}
