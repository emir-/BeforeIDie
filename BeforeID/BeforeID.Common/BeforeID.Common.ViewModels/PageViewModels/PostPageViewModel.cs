using System;
using BeforeID.Common.ViewModels.BaseViewModels;

namespace BeforeID.Common.ViewModels.PageViewModels
{
    /// <summary>
    /// The view model for the post page containing all the relevant information 
    /// for a given user to make a post
    /// </summary>
    public class PostPageViewModel:BaseViewModel
    {
        public Guid CategoryId { get; set; }

        public string CategoryText { get; set; }
    }
}
