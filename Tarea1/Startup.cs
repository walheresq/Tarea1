using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea1.Startup))]
namespace Tarea1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
