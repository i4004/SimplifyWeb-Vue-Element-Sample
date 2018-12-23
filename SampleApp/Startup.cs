using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Hosting;
using Simplify.Web.Owin;

namespace SampleApp
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseSimplifyWebNonTerminal();

			app.UseSpa(spa =>
			{
				spa.Options.SourcePath = "ClientApp";

				if (env.IsDevelopment())
					spa.UseAngularCliServer("start");
			});
		}
	}
}