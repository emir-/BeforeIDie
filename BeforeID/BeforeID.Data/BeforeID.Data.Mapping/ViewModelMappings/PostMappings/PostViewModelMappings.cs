using BeforeID.Common.ViewModels.PostViewModels;
using BeforeID.Data.Model.Entities;

namespace BeforeID.Data.Mapping.ViewModelMappings.PostMappings
{
    public class PostViewModelMappings
    {
        #region To Entitiy

        public static Post GetPostFromEditViewModel(PostEditViewModel viewModel)
        {
            var post = new Post()
                       {
                           CategoryId = viewModel.PostCategoryId,
                           Text = viewModel.PostText,
                           ColorCode = viewModel.PostColor
                       };

            return post;
        }

        #endregion

        #region From Entity

        public static PostDisplayViewModel GetPostDisplayViewModel(Post post)
        {
            var viewModel = new PostDisplayViewModel()
                            {
                                Id = post.Id,
                                CategoryText = post.Category.CategoryText,
                                PostText = post.Text,
                                PostColor = string.IsNullOrEmpty(post.ColorCode) ? "#FFF" : post.ColorCode,
                                Date = post.DateCreated.ToShortDateString() + " " + post.DateCreated.ToShortTimeString()
                            };

            return viewModel;
        }

        #endregion
    }
}
