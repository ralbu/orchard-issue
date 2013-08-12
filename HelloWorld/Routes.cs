﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Mvc.Routes;

namespace HelloWorld
{
    public class Routes : IRouteProvider
    {
        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
            {
                routes.Add(routeDescriptor);
            }
        }

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[]
                       {
                           new RouteDescriptor
                               {
                                   Priority = 5,
                                   Route = new Route(
                                       "HelloWorld",
                                       new RouteValueDictionary
                                           {
                                               {"area", "HelloWorld"},
                                               {"controller", "Home"},
                                               {"action", "Index"}
                                           },
                                       new RouteValueDictionary(),
                                       new RouteValueDictionary
                                           {
                                               {"area", "HelloWorld"}
                                           },
                                       new MvcRouteHandler())
                               }
                       };
        }
    }
}