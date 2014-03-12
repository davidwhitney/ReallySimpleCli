using ReallySimpleCli.TestApp.Controllers;

namespace ReallySimpleCli.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = App.Bootstrap(x =>
            {
                x.RouteTable.MapRoute("Default", typeof (DefaultController));
                x.RouteTable.MapRoute("RouteName", typeof (MyController));
                x.RouteTable.MapRoute("RouteName1", typeof (MyOtherController));
                x.RouteTable.MapRoute("RouteName2", typeof (MyThirdController));
            });

            application.Start(args);
        }
    }
}
