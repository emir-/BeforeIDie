using BeforeID.Common.ViewModels.BaseViewModels;

namespace BeforeID.Common.ViewModels.CommonViewModels
{
    public class JsonResultViewModel:BaseViewModel
    {
        #region Properties
        public bool Status { get; set; }

        public object Data { get; set; }

        #endregion
        
        #region Constructor

        public JsonResultViewModel()
        {
            IsValid = false;
            Status = false;
            Data = null;
        }

        #endregion

        
    }

}
