using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba9Dic.Startup))]
namespace Prueba9Dic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
