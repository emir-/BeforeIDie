using System;

namespace BeforeID.Data.Model.Seeders.Common
{
    public static class SeededUserInformation
    {
        #region Admin

        public static Guid Admin_Id = Guid.Parse("8b825547-b4f5-4dd7-af02-9e63b669fe4f");
        public static string Admin_Name = "Admin";
        public static string Admin_Password = "developer";
        public static string Admin_City = "Skopje";
        public static string Admin_Comment = "I am the administrator. Bow down before the administrator noobs";
        public static string Admin_Profession = "Developer";

        #endregion
    }
}
