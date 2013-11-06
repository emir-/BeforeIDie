using System.Collections.Generic;
using BeforeID.Data.Model.Context;
using BeforeID.Data.Model.Entities;
using BeforeID.Data.Model.Seeders.Common;

namespace BeforeID.Data.Model.Seeders.UserSeed
{
    public static class BaseUserSeeder
    {
        public static void Seed(BidContext context)
        {
            // seed some posts from the bid categroy
            var posts = new List<User>()
                        {
                            new User()
                            {
                                Id = SeededUserInformation.Admin_Id,
                                Name = SeededUserInformation.Admin_Name,
                                Password = SeededUserInformation.Admin_Password,
                                City = SeededUserInformation.Admin_City,
                                Comment = SeededUserInformation.Admin_Comment,
                                Profession = SeededUserInformation.Admin_Profession
                            }
                        };

            posts.ForEach(post=>context.Users.Add(post));

            context.SaveChanges();
        }
    }
}
