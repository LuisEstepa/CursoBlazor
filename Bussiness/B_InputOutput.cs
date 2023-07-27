using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class B_InputOutput
    {
        public List<InputOutputEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateCategory(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges();
            }

        }

        public void UpdateCategory(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOutput);
                db.SaveChanges();
            }
        }

        public InputOutputEntity GetCategoryForId(string oInputOutputId)
        {
            using (var db = new InventaryContext())
            {
                var inputOutput = db.InOuts.Select(p => p.InputOutputId == oInputOutputId);

                return (InputOutputEntity)inputOutput;
            }
        }

        public void DeleteCategoryForId(string oInputOutputId)
        {
            using (var db = new InventaryContext())
            {
                // Find the entity to be deleted.
                var registro = db.InOuts.FirstOrDefault(e => e.InputOutputId == oInputOutputId);

                // Delete the entity.
                db.InOuts.Remove(registro);

                // Save the changes.
                db.SaveChanges();
            }
        }
    }
}
