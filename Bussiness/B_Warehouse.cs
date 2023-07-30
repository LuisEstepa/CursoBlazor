using DataAccess;
using Entities;

namespace Bussiness
{
    public class B_Warehouse
    {
        public List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        //Crear registro

        public void CreateWarehouse(WarehouseEntity oParam)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oParam);
                db.SaveChanges();
            }

        }
        // Actualizar registro

        public void UpdateWarehouse(WarehouseEntity oParam)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Update(oParam);
                db.SaveChanges();
            }
        }

        //Obtener registro por Id

        public WarehouseEntity GetWarehouseForId(string oParamId)
        {
            using (var db = new InventaryContext())
            {
                var registro = db.Warehouses.FirstOrDefault(p => p.WarehouseId == oParamId);

                return registro;
            }
        }

        //Eliminar fisico
        public void DeleteWarehouseForId(string oParamId)
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

