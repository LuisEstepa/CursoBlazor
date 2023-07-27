using DataAccess;
using Entities;

namespace Bussiness
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList() 
        {
            using var db = new InventaryContext();
            return db.Categories.ToList();
        }

        public static void CreateCategory(CategoryEntity oCategory)
        {
            using var db = new InventaryContext();
            db.Categories.Add(oCategory);
            db.SaveChanges();
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using var db = new InventaryContext();
            db.Categories.Update(oCategory);
            db.SaveChanges();
        }

        public static CategoryEntity GetCategoryForId(string oCategoryId)
        {
            using var db = new InventaryContext();
            var category = db.Categories.Where(p => p.CategoryId == oCategoryId);
            return (CategoryEntity)category;
        }
    }
}
