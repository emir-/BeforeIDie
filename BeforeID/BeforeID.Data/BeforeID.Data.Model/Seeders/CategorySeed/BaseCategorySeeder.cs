using System.Collections.Generic;
using BeforeID.Data.Model.Context;
using BeforeID.Data.Model.Entities;
using BeforeID.Data.Model.Seeders.Common;

namespace BeforeID.Data.Model.Seeders.CategorySeed
{
    public static class BaseCategorySeeder
    {
        public static void Seed(BidContext context)
        {
            var categories = new List<Category>()
                             {
                                 new Category()
                                 {
                                     Id=SeededCategoryIds.BIDCategory,
                                     CategoryText = "Пред да умрам",
                                 }
                             };

            categories.ForEach(category => context.Categories.Add(category));
            context.SaveChanges();
        }
    }
}
