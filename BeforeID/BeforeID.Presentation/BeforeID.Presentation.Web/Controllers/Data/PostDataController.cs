using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using BeforeID.Common.ViewModels.PostViewModels;
using BeforeID.Data.Mapping.ViewModelMappings.CommonMappings;
using BeforeID.Data.Mapping.ViewModelMappings.PostMappings;
using BeforeID.Data.Model.Context;
using BeforeID.Data.Model.Entities;

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

        [HttpPost]
        public ActionResult ReadPosts(PostsQueryModel queryModel)
        {
            try
            {
                var postsQuery = _bidContext.Posts
                    .AsQueryable()
                    .Include(t => t.Category)
                    .OrderByDescending(t => t.DateCreated)
                    .Skip(queryModel.Skip)
                    .Take(queryModel.Take);

                var viewModelObjects = postsQuery.ToList().Select(PostViewModelMappings.GetPostDisplayViewModel);
                return Json(JsonResultMappings.Success(viewModelObjects));
            }
            catch (Exception ex)
            {
                return Json(JsonResultMappings.Error());
            }
        }

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

                    // reget the post so we get the category info
                    post = _bidContext.Posts
                        .Include(p => p.Category)
                        .FirstOrDefault(t => t.Id == post.Id);

                    return Json(JsonResultMappings.Success(PostViewModelMappings.GetPostDisplayViewModel(post)));
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