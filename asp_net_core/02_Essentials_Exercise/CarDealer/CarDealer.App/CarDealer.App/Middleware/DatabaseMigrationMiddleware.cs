﻿namespace CarDealer.App.Middleware
{
    using Data;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Threading.Tasks;

    public class DatabaseMigrationMiddleware
    {
        private readonly RequestDelegate next;

        public DatabaseMigrationMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context
                .RequestServices
                .GetRequiredService<CarDealerDbContext>()
                .Database
                .Migrate();

            return this.next(context);
        }
    }
}
