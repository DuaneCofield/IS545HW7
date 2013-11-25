using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW7.Startup))]
namespace HW7
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
