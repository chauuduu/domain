using Application.Data;
using Application.ViewModel;
using Domain.Cloth;
using Infrastructure.Interface;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class ClothesService : IClothesService
    {

        readonly IClothesRepository ClothesRepository;
        public ClothesService(IClothesRepository _ClothesRepository)
        {
            this.ClothesRepository = _ClothesRepository;
        }

        public async Task<string> Delete(int Id)
        {
            return await ClothesRepository.DeleteAsync(Id);
        }



        public async Task<IEnumerable<Clothes>> GetAll()
        {
            return await ClothesRepository.GetAllAsync();
        }

        public List<ClothesViewModel> GetList()
        {
            using (var db = new MyDbContext())
            {
                var rs = db.Clothes.Select(e => new ClothesViewModel
                {
                    ID = e.ID,
                    Name = e.Name,
                    Description= e.Description,
                    Price= e.Price,
                    RentalPrice= e.RentalPrice,
                    RentalTime = e.RentalTime,
                    IDOrigin= e.IDOrigin,
                    IDType= e.IDType,
                    IsRental= e.IsRental,
                    Size= e.Size,
                }).ToList();
                return rs;
            }
        }

        public async Task<String> Insert(Clothes p)
        {
            return await ClothesRepository.InsertAsync(p);
        }


        public async Task<string> Update(Clothes p)
        {
            return await ClothesRepository.UpdateAsync(p);
        }
    }
}
