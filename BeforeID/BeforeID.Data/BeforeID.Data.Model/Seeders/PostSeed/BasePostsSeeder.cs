using System.Collections.Generic;
using BeforeID.Data.Model.Context;
using BeforeID.Data.Model.Entities;
using BeforeID.Data.Model.Seeders.Common;

namespace BeforeID.Data.Model.Seeders.PostSeed
{
    public static class BasePostsSeeder
    {
        public static void Seed(BidContext context)
        {
            // seed some posts from the bid categroy
            var posts = new List<Post>()
                        {
                            new Post()
                            {
                                CategoryId = SeededCategoryIds.BIDCategory,
                                Text = "Да ја видам уште еднаш",
                                ColorCode = "#46A229",
                                PostUserName = "Бетмен",
                                PostUserCity = "Скопје",
                                PostUserComment = "Хах!",
                                PostUserProfession = "Суперхерој",
                            },

                            new Post()
                            {
                                CategoryId = SeededCategoryIds.BIDCategory,
                                Text = "Да одам на одмор на Тахити",
                                ColorCode = "#37B6CE",
                                PostUserName = "Бетмен",
                                PostUserCity = "Скопје",
                                PostUserProfession = "Суперхерој",
                            },

                            new Post()
                            {
                                CategoryId = SeededCategoryIds.BIDCategory,
                                Text = "Да вистински се заљубам",
                                ColorCode = "#F93E58",
                                PostUserName = "Бетмен",
                                PostUserCity = "Скопје",
                                PostUserProfession = "Суперхерој",
                            },

                            new Post()
                            {
                                CategoryId = SeededCategoryIds.BIDCategory,
                                Text = "Да истрчам маратон...",
                                ColorCode = "#015666",
                                UserId = SeededUserInformation.Admin_Id,
                                PostUserName = SeededUserInformation.Admin_Name,
                                PostUserComment = SeededUserInformation.Admin_Comment,
                                PostUserCity = SeededUserInformation.Admin_City,
                                PostUserProfession = SeededUserInformation.Admin_Profession,
                            }
                        };

            posts.ForEach(post => context.Posts.Add(post));
            context.SaveChanges();
        }
    }
}
