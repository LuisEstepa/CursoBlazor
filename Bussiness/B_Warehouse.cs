using DataAccess;
using Entities;

namespace Bussiness
{
    public class B_Warehouse
    {
        public class B_Storage
        {
            public List<WarehouseEntity> CategoryList()
            {
                using (var db = new InventaryContext())
                {
                    return db.Warehouses.ToList();
                }
            }

            //Crear registro

            public void CreateCategory(WarehouseEntity oParam)
            {
                using (var db = new InventaryContext())
                {
                    db.Warehouses.Add(oParam);
                    db.SaveChanges();
                }

            }
            // Actualizar registro

            public void UpdateCategory(WarehouseEntity oParam)
            {
                using (var db = new InventaryContext())
                {
                    db.Warehouses.Update(oParam);
                    db.SaveChanges();
                }
            }

            //Obtener registro por Id

            public WarehouseEntity GetCategoryForId(string oParamId)
            {
                using (var db = new InventaryContext())
                {
                    var registro = db.Warehouses.Select(p => p.WarehouseId == oParamId);

                    return (WarehouseEntity)registro;
                }
            }

            //Eliminar fisico
            public void DeleteCategoryForId(string oParamId)
            {
                using (var db = new InventaryContext())
                {
                    // Find the entity to be deleted.
                    var registro = db.Warehouses.FirstOrDefault(e => e.WarehouseId == oParamId);

                    // Delete the entity.
                    db.Warehouses.Remove(registro);

                    // Save the changes.
                    db.SaveChanges();
                }
            }
        }
    }
}
