using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comunicacion_Datos.Startup))]
namespace Comunicacion_Datos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
