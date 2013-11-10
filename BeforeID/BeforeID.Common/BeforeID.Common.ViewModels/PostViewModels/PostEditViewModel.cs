using System;
using BeforeID.Common.ViewModels.BaseViewModels;

namespace BeforeID.Common.ViewModels.PostViewModels
{
    public class PostEditViewModel:BaseViewModel
    {
        public Guid PostCategoryId { get; set; }      
        public string PostText { get; set; }
    }
}
