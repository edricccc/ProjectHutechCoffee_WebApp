using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HutechCoffee.Startup))]
namespace HutechCoffee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
