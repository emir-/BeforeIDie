using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeforeID.Presentation.Web.Controllers.Data
{
    public class CategoryDataController : Controller
    {
        //
        // GET: CategoryData/ReadDefaultCategory/
        public ActionResult ReadDefaultCategory()
        {
            return Json("Ok");
        }
	}
}