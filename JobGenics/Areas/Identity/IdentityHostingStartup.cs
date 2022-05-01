using System;
using JobGenics.Areas.Identity.Data;
using JobGenics.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(JobGenics.Areas.Identity.IdentityHostingStartup))]
namespace JobGenics.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<JobGenicsContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("JobGenicsContextConnection")));

                services.AddDefaultIdentity<JobGenicsUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<JobGenicsContext>();
            });
        }
    }
}