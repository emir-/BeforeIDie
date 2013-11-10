using System.Linq;
using System.Web.Mvc;
using BeforeID.Common.Infrastructure.Registries;
using BeforeID.Data.Mapping.ViewModelMappings.PageMappings;
using BeforeID.Data.Model.Context;

namespace BeforeID.Controllers
{
    public class HomeController : Controller
    {
        #region Properties

        private readonly BidContext _bidContext;
        
        #endregion

        #region Constructor

        public HomeController()
        {
            _bidContext = new BidContext();
        }

        #endregion

        #region View Actions

        public ActionResult Index()
        {

            //get the default category
            var category = _bidContext.Categories.FirstOrDefault(x => x.CategoryAlias == CategoryAliases.Bid);

            var viewModel = PostPageViewModelMappings.BuildFromCategory(category);

            return View(viewModel);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        #endregion
    }
}