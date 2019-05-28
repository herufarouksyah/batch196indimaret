using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Indimaret;

namespace Repo.Indimaret
{
    public class BarangRepo
    {
        public static List<Barang> GetAll()
        {
            List<Barang> result = new List<Barang>();
            using (DataContext db = new DataContext())
            {
                result = db.Barang.ToList();
            }
            return result;
        }

        public static Boolean Createbarang(Barang barang)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.Barang.Add(barang);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
            return true;
        }
    }
}
