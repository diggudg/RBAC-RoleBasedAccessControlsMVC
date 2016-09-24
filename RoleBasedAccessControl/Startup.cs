using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoleBasedAccessControl.Startup))]
namespace RoleBasedAccessControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
