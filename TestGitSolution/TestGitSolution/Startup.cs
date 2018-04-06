using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitSolution.Startup))]
namespace TestGitSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
