using DataAccess;
using Entities;

namespace Bussiness
{
    public class B_Storage
    {
        public List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }

        //Crear registro

        public void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {   
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }

        }

        public bool IsProductInWarehouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList()
                    .Where(p => p.StorageId == idStorage);
                return product.Any();
            }

        }

        // Actualizar registro

        public void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }

        //Obtener registro por Id

        public StorageEntity GetStorageForId(string oProductId)
        {
            using (var db = new InventaryContext())
            {
                var registro = db.Storages.FirstOrDefault(p => p.StorageId == oProductId);

                return registro;
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
