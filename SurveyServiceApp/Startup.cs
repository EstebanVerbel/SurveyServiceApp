using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SurveyServiceApp.Startup))]

namespace SurveyServiceApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}