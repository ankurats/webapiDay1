using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HelloWorldApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            //config.MapHttpAttributeRoutes();
            //config.Formatters.Remove(config.Formatters.JsonFormatter);

            config.Routes.MapHttpRoute(
              name: "helloworld",
              routeTemplate: "app/HelloWorld/{id}",
              defaults: new { controller= "HelloWorld", id = RouteParameter.Optional }
          );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
