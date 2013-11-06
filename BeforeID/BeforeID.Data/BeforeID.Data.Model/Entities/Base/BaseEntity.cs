using System;

namespace BeforeID.Data.Model.Entities.Base
{
    public class BaseEntity
    {

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.Now;
        }

        #endregion

        #region Properties

        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        #endregion
    }
}
