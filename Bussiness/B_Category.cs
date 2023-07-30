using DataAccess;
using Entities;

namespace Bussiness
{
    public class B_Category
    {
        public  List<CategoryEntity> CategoryList() 
        {
            using var db = new InventaryContext();            
            return db.Categories.ToList();
        }

        public void CreateCategory(CategoryEntity oCategory)
        {
            using var db = new InventaryContext();
            //oCategory.CategoryId = Guid.NewGuid().ToString();
            db.Categories.Add(oCategory);
            db.SaveChanges();
        }

        public void UpdateCategory(CategoryEntity oCategory)
        {
            using var db = new InventaryContext();
            db.Categories.Update(oCategory);
            db.SaveChanges();
        }

        public CategoryEntity GetCategoryForId(string oProductId)
        {
            using (var db = new InventaryContext())
            {
                var registro = db.Categories.FirstOrDefault(p => p.CategoryId == oProductId);

                return registro;
            }
        }
    }
}
