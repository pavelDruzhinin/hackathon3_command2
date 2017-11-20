using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DominosPizza.Startup))]
namespace DominosPizza
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
