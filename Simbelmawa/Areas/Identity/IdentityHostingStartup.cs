using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Simbelmawa.Data;
using Simbelmawa.Identity;
using Simbelmawa.Models.Pengguna;

[assembly: HostingStartup(typeof(Simbelmawa.Areas.Identity.IdentityHostingStartup))]
namespace Simbelmawa.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PenggunaDbContext>(options =>
                    options.UseNpgsql(context.Configuration.GetConnectionString("DefaultConnection")));

                // Identity types
                services.AddIdentity<SimbelmawaUser, Peran>();

                // Identity stores
                services.AddTransient<IUserStore<SimbelmawaUser>, SimbelmawaUserStore>();
                services.AddTransient<IRoleStore<Peran>, SimbelmawaRoleStore>();

                // Password Hasher for Identity Manager
                services.AddScoped<IPasswordHasher<SimbelmawaUser>, SimbelmawaPasswordHasher>();

                // Bypassing normalizer
                services.AddSingleton<ILookupNormalizer, BypassNormalizer>();
            });
        }
    }
}