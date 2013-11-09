using System.Collections.Generic;
using BeforeID.Data.Model.Entities.Base;

namespace BeforeID.Data.Model.Entities
{
    public class Category:BaseEntity
    {
        #region Properties

        /// <summary>
        /// The text for the category of posts: 
        /// 
        /// For example - Before I die.... 
        /// 
        /// It can define multiple tapestries:  Before I get married...
        /// 
        /// Initialiiy will on
        /// </summary>
        public string CategoryText { get; set; }

        /// <summary>
        /// The alias for the category. Used to query default categories.
        /// </summary>
        public string CategoryAlias { get; set; }

        #endregion

        #region Navigation Properties
        
        public virtual ICollection<Post> Posts { get; set; }

        #endregion
    }
}