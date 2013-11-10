namespace BeforeID.Common.ViewModels.BaseViewModels
{
    /// <summary>
    /// Base Viewmodel for all the application view models containing the common view model data
    /// </summary>
    public class BaseViewModel
    {
        /// <summary>
        /// Determine if a view model is valid
        /// </summary>
        public bool IsValid { get; set; }
        
        /// <summary>
        /// View model message  either used during display or loading of any data.
        /// </summary>
        public string ViewModelMessage { get; set; }
    }
}
