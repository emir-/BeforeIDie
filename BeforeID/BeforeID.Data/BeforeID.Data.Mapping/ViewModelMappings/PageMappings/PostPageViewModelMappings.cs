using BeforeID.Common.ViewModels.PageViewModels;
using BeforeID.Data.Model.Entities;

namespace BeforeID.Data.Mapping.ViewModelMappings.PageMappings
{
    /// <summary>
    /// Contains mappings for the post page view models
    /// </summary>
    public class PostPageViewModelMappings
    {
        public static PostPageViewModel BuildFromCategory(Category postCategory)
        {
            var viewModel = new PostPageViewModel();

            if (postCategory == null)
            {
                viewModel.IsValid = false;
                viewModel.ViewModelMessage = "Грешка во апликацијата. Пробајте поново";
            }
            else
            {
                viewModel.IsValid = true;
                viewModel.CategoryText = postCategory.CategoryText;
                viewModel.CategoryId = postCategory.Id;
            }

            return viewModel;
        }
    }
}
