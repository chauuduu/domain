using Application.Service;
using Domain.Cloth;
using Microsoft.AspNetCore.Mvc;

namespace ClothesRentalShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClothesController : ControllerBase
    {
        readonly IClothesService ClothesService;
        public ClothesController(IClothesService ClothesService)
        {
            this.ClothesService = ClothesService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await ClothesService.GetAll());
            //return Ok(ClothesService.GetList());
        }
        [HttpPost]
        public async Task<IActionResult> Insert(Clothes ClothesEx)
        {
            return Ok(await ClothesService.Insert(ClothesEx));
        }
        [HttpPut]
        public async Task<IActionResult> Update(Clothes ClothesEx)
        {
            return Ok(await ClothesService.Update(ClothesEx));
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            return Ok(await ClothesService.Delete(Id));
        }
    }
}

