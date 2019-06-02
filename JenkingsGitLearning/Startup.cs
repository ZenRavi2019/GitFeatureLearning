using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkingsGitLearning.Startup))]
namespace JenkingsGitLearning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
