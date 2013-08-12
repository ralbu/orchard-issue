using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orchard.DisplayManagement;
using Orchard.Themes;

namespace HelloWorld.Controllers
{
    [Themed]
    public class HomeController : Controller
    {
        private readonly dynamic _shapeFactory;

        [Themed(false)]
        public ActionResult Index()
        {
            return View(_shapeFactory.MyShape(
                Foo: 42,
                Bar: "baz"
                ));

            //return View("HelloWorld");
        }

        public HomeController(IShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
        }
        
    }
}