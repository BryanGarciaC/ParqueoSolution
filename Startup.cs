using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParqueoSolution.Startup))]
namespace ParqueoSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
