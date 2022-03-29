using System;
using AuthenticatedWebApplication.Areas.Identity.Data;
using AuthenticatedWebApplication.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AuthenticatedWebApplication.Areas.Identity.IdentityHostingStartup))]
namespace AuthenticatedWebApplication.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthenticatedWebApplicationContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthenticatedWebApplicationContextConnection")));

                services.AddDefaultIdentity<AuthenticatedWebApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AuthenticatedWebApplicationContext>();
            });
        }
    }
}