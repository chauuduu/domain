using Application.ViewModel;
using Domain.Cloth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public interface IClothesService
    {
        Task<IEnumerable<Clothes>> GetAll();
        Task<String> Insert(Clothes p);
        Task<String> Update(Clothes p);
        Task<String> Delete(int Id);
        List<ClothesViewModel> GetList();
    }
}
