using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
           // config.EnableCors(new EnableCorsAttribute("http://localhost:4200", headers: "*", methods: "*"));
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.EnableCors();
            //////מתהילה
            var formatters = GlobalConfiguration.Configuration.Formatters;

            formatters.Remove(formatters.XmlFormatter);
            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.DateFormatHandling
            = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;


            var json2 = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json2.UseDataContractJsonSerializer = true;/////מתהילה
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.EnableCors();
        }
    }
}
