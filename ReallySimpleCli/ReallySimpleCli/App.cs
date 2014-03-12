using System;
using System.Collections.Generic;
using ReallySimpleCli.ActionResults;
using ReallySimpleCli.Controllers;

namespace ReallySimpleCli
{
    public class App
    {
        private readonly AppConfiguration _configuration;
        
        private App(AppConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Start(string[] args)
        {
            var controllerType = _configuration.RouteTable["Default"];
            var instance = (Controller)Activator.CreateInstance(controllerType);
            
            var result = (IActionResult)controllerType.GetMethod("Get").Invoke(instance, null);

            result.Execute();
            
        }

        public static App Bootstrap(Action<AppConfiguration> action)
        {
            var configuration = new AppConfiguration();

            action(configuration);

            return new App(configuration);
        }
    }

    public class AppConfiguration
    {
        public RouteTable RouteTable { get; set; }

        public AppConfiguration()
        {
            RouteTable = new RouteTable();
        }
    }

    public class RouteTable : Dictionary<string, Type>
    {
        public void MapRoute(string routename, Type type)
        {
            Add(routename, type);
        }
    }
}
