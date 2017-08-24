using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RCMD.Report.Startup))]
namespace RCMD.Report
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
