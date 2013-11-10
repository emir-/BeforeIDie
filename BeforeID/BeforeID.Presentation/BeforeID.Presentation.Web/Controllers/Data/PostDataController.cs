using System;
using System.Web.Mvc;
using BeforeID.Common.ViewModels.PostViewModels;
using BeforeID.Data.Mapping.ViewModelMappings.CommonMappings;
using BeforeID.Data.Mapping.ViewModelMappings.PostMappings;
using BeforeID.Data.Model.Context;

namespace BeforeID.Presentation.Web.Controllers.Data
{
    public class PostDataController : Controller
    {
        #region Properties

        private readonly BidContext _bidContext;

        #endregion

        #region Constructor

        public PostDataController()
        {
            _bidContext = new BidContext();
        }

        #endregion

        /// <summary>
        /// Save a post
        /// </summary>
        /// <param name="?"></param>
        /// <param name="postModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Save(PostEditViewModel postModel)
        {
            if (ModelState.IsValid)
            {
                var post = PostViewModelMappings.GetPostFromEditViewModel(postModel);

                try
                {
                    _bidContext.Posts.Add(post);
                    _bidContext.SaveChanges();

                    return Json(JsonResultMappings.Success(post));
                }
                catch (Exception ex)
                {
                    return Json(JsonResultMappings.Error());
                }
            }
            else
            {
                return Json(JsonResultMappings.Error());
            }
        }
    }
}