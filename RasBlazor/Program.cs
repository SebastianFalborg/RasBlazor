using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
using Umbraco.Headless.Client.Net.Configuration;
using Umbraco.Headless.Client.Net.Security;
using Blazored.Modal;

namespace RasBlazor
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.Services.AddSingleton<LocalStorageService>();
			builder.Services.AddBlazoredModal();
			builder.RootComponents.Add<App>("app");

			await builder.Build().RunAsync();
		}
	}
}
