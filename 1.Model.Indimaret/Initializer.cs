using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Indimaret
{
    public class Initializer: DropCreateDatabaseAlways<DataContext>
    {


        protected override void Seed(DataContext context)
        {
            List<Barang> barang = new List<Barang>();
            barang.Add(new Barang { TokoID = 1, KodeBarang = "KB001", NamaBarang = "Panadol", AsalPabrik = "Bogor", JmlBarang = 30, LamaKadaluarsa = 10 });
            barang.Add(new Barang { TokoID = 1, KodeBarang = "KB002", NamaBarang = "Dekolgen", AsalPabrik = "Bandung", JmlBarang = 5, LamaKadaluarsa = 40 });
            barang.Add(new Barang { TokoID = 1, KodeBarang = "KB003", NamaBarang = "Promag", AsalPabrik = "Jakarta", JmlBarang = 12, LamaKadaluarsa = 15 });
            barang.Add(new Barang { TokoID = 2, KodeBarang = "KB004", NamaBarang = "Vit C", AsalPabrik = "Yogya", JmlBarang = 23, LamaKadaluarsa = 20 });

            base.Seed(context);
            foreach (Barang item in barang)
            {
                context.Barang.Add(item);
            }

            
        }
    }
}
