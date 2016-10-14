using MVCmappimgTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCmappimgTest.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            var model = new MainModel();

            model.checks = new List<bool>();
            model.subModels = new List<MainModel.SubModel>();
            for (int i = 0; i < 3; i++)
            {
                var item = new MainModel.SubModel();
                item.No = i;
                item.Name = "Test"+i.ToString();
                item.Check = "false";
                model.subModels.Add(item);
                model.checks.Add( false);
            }

            TempData["Model"] = model;

            return View(model);
        }

        public ActionResult Send(MainModel model)
        {
            var temp = model.checks;

            model = TempData["Model"] as MainModel;

            model.checks = temp;

            TempData["Model"] = model;

            return View("Index", model);
        }
    }
}
