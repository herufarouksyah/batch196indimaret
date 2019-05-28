using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Indimaret;
using Repo.Indimaret;

namespace Service.Indimaret
{
    public class BarangServiceImplementation : BarangServiceInterface
    {
        public  List<Barang> GetAll()
        {
            return BarangRepo.GetAll();
        }
    }
}
