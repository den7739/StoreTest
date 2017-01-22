using System.Web.Mvc;
using System.Web.Routing;
using SportsStore.WebUI.Infrastracture;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Binders;

namespace SportsStore.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
        }
    }
}
