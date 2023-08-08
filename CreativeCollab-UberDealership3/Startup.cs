using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreativeCollab_UberDealership3.Startup))]
namespace CreativeCollab_UberDealership3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
