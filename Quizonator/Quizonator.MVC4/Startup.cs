using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quizonator.MVC4.Startup))]
namespace Quizonator.MVC4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
