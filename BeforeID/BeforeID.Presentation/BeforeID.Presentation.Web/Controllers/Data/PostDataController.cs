using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeforeID.Presentation.Web.Controllers.Data
{
    public class PostDataController : Controller
    {
        #region Properties

        #endregion
        //
        // GET: /PostData/Read/
        public ActionResult Read()
        {
            return Json("OK");
        }
	}
}