using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var logpath = System.Web.Hosting.HostingEnvironment.MapPath("~/Logger/Log.txt");

            var log = new LoggerConfiguration()
                .WriteTo.File(logpath)
                .CreateLogger();

            log.Information("Este es un log de prueba de WebApi con Net Framework 4.6");

            try
            {
                int a = 2;
                int b = 0;
                log.Warning("Los valores son {0} and {1}", a, b);
                int c = a / b;
            }
            catch (Exception ex)
            {
                log.Error(ex, "Ocurrio un error");
            }

            return View();
        }
    }
}
