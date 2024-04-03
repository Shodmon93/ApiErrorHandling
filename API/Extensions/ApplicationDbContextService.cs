using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationDbContextService
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlite(builder.Configuration.GetConnectionString("Default"));
            });
            return services;
        }

    }
}