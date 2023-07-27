using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_Storage
    {
        public List<StorageEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        //Crear registro

        public void CreateCategory(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }

        }
        // Actualizar registro

        public void UpdateCategory(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }

        //Obtener registro por Id

        public StorageEntity GetCategoryForId(string oStorageId)
        {
            using (var db = new InventaryContext())
            {
                var registro = db.Storages.Select(p => p.ProductId == oStorageId);

                return (StorageEntity)registro;
            }
        }

        //Eliminar fisico
        public void DeleteCategoryForId(string oStorageId)
        {
            using (var db = new InventaryContext())
            {
                // Find the entity to be deleted.
                var registro = db.Storages.FirstOrDefault(e => e.StorageId == oStorageId);

                // Delete the entity.
                db.Storages.Remove(registro);

                // Save the changes.
                db.SaveChanges();
            }
        }
    }
}
