using System;
using BeforeID.Data.Model.Entities.Base;

namespace BeforeID.Data.Model.Entities
{
    public class Post:BaseEntity
    {
        #region Base Properties

        public string Text { get; set; }

        public string ColorCode { get; set; }

        #region Anon User Data

        /*
         * Post User information will either be loaded from logged in user or
         * anonymous users can fill the data
         */

        public string PostUserName { get; set; }

        public string PostUserCity { get; set; }

        public string PostUserComment { get; set; }

        public string PostUserProfession { get; set; }

        #endregion

        public Guid? UserId { get; set; }

        public Guid CategoryId { get; set; }

        #endregion

        #region Navigation Properties

        public virtual User User { get; set; }

        public virtual Category Category { get;set; }
       
        #endregion
    }
}
