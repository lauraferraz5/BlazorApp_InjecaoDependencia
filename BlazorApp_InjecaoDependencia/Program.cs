using BlazorApp_InjecaoDependencia.Servicos;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp_InjecaoDependencia
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            //Adicionando os servi�os
            builder.Services.AddScoped<ServicoScoped>();

            builder.Services.AddSingleton<ServicoSingleton>();

            builder.Services.AddTransient<ServicoTransient>();

            await builder.Build().RunAsync();
        }
    }
}
