using LightInject;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

[assembly: OwinStartupAttribute(typeof(WebDeveloper.Startup))]
namespace WebDeveloper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = new ServiceContainer();
            //container.Register<IDataAccess<Client>, ClientData>();
            //registrar ensamblados
            container.RegisterAssembly(Assembly.GetExecutingAssembly());
            container.RegisterAssembly("WebDeveloper.*.dll");
            //registra hacia los controlares
            container.RegisterControllers();
            //estos controladores son del tipo MVC
            container.EnableMvc();
        }
    }
}
