namespace BeforeID.Common.ViewModels.PostViewModels
{
    public class PostsQueryModel
    {
        #region Properties

        public int Skip { get; set; }

        public int Take { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public PostsQueryModel()
        {
            Skip = 0;
            Take = 10;
        }

        #endregion
    }
}
