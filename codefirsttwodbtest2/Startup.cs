using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codefirsttwodbtest2.Startup))]
namespace codefirsttwodbtest2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
