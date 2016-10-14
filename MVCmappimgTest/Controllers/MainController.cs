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
            for (int i = 0; i < 4; i++)
            {
                var item = new MainModel.SubModel();
                item.No = model.subModels.Count;
                item.Name = "Test" + i.ToString();
                item.Check = "false";
                item.IsExist = true;
                model.subModels.Add(item);
                model.checks.Add( false);
            }

            //3の倍数になるようにダミー作成
            while ((model.subModels.Count%3) > 0)
            {
                var item = new MainModel.SubModel();
                item.No = model.subModels.Count;
                item.IsExist = false;
                model.subModels.Add(item);
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
