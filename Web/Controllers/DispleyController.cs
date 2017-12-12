using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkadTechDomain;

namespace Web.Controllers
{
    public class DispleyController : Controller
    {
        ItemZs itemZs = new ItemZs
        {
            IdZs = 1,
        SubSystem = "BK",
        ItemZsName="Part01",
        Type="my",
        Artikul="Fresh",
        Esn="00121111"
        };

    // GET: Displey
    public ActionResult Index()

        {
        
            return View(itemZs);
        }
    }
}