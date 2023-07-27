using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_Product
    {
        public List<ProductEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        //Crear registro

        public void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }

        }
        // Actualizar registro

        public void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }

        //Obtener registro por Id

        public ProductEntity GetProductForId(string oProductId)
        {
            using (var db = new InventaryContext())
            {
                var registro = db.Products.Select(p => p.ProductId == oProductId);

                return (ProductEntity)registro;
            }
        }

        //Eliminar fisico
        public void DeleteProductForId(string oProductId)
        {
            using (var db = new InventaryContext())
            {
                // Find the entity to be deleted.
                var registro = db.Products.FirstOrDefault(e => e.ProductId == oProductId);

                // Delete the entity.
                db.Products.Remove(registro);

                // Save the changes.
                db.SaveChanges();
            }
        }
    }
}
