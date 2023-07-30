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
        public List<InputOutputEntity> InOutsList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public void CreateInOuts(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInputOutput);
                db.SaveChanges();
            }

        }

        public void UpdateInOuts(InputOutputEntity oInputOutput)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInputOutput);
                db.SaveChanges();
            }
        }

        public InputOutputEntity GetInOuts(string oInputOutputId)
        {
            using (var db = new InventaryContext())
            {
                var registro = db.InOuts.FirstOrDefault(p => p.InputOutputId == oInputOutputId);

                return registro;
            }
        }

        public void DeleteInOutsForId(string oInputOutputId)
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
