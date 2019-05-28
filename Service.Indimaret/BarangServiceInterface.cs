using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo.Indimaret;
using Model.Indimaret;

namespace Service.Indimaret
{
    public interface BarangServiceInterface
    {
          List<Barang> GetAll(); 
    }
}
