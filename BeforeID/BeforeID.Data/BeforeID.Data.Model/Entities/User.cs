using System.Collections.Generic;
using BeforeID.Data.Model.Entities.Base;

namespace BeforeID.Data.Model.Entities
{
    /// <summary>
    /// Simplest User storing username/password and basic user information. Logged in users will
    /// only get auto form fill in extra information for the Posts
    /// </summary>
    public class User : BaseEntity
    {
        #region Base Properties
        
        /// <summary>
        /// User inputed name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Basic user credential password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The optinal city input from where the user makes the post.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The profession of the user.
        /// </summary>
        public string Profession { get; set; }

        /// <summary>
        ///  Anything else the user making the post wants to reveal about himself. This can be overiden for the posts.
        /// 
        /// Can be considered as a user signature.
        /// </summary>
        public string Comment { get; set; }

        #endregion

	    #region  Navigation Properties

        public virtual ICollection<Post> Posts { get; set; }

        #endregion
    }

}
