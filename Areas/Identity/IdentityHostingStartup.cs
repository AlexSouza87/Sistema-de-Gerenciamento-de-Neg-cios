using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaGerenciadorDeNegocios.Areas.Identity.Data;
using SistemaGerenciadorDeNegocios.Data;

[assembly: HostingStartup(typeof(SistemaGerenciadorDeNegocios.Areas.Identity.IdentityHostingStartup))]
namespace SistemaGerenciadorDeNegocios.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SistemaGerenciadorDeNegociosContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SistemaGerenciadorDeNegociosContextConnection")));

                services.AddDefaultIdentity<SistemaGerenciadorDeNegociosUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<SistemaGerenciadorDeNegociosContext>();
            });
        }
    }
}