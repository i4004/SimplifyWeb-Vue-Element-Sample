using Owin;
using Simplify.Web.Owin;

namespace SampleApp
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.UseSimplifyWeb();
		}
	}
}