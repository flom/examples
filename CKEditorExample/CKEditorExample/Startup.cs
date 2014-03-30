using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CKEditorExample.Startup))]
namespace CKEditorExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
