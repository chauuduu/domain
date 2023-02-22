using Application.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Data
{
    public class MyDbContext : DbContext
    {

        public virtual DbSet<ClothesViewModel> Clothes { get; set; }
        private const string connectionString = @"Server=DESKTOP-FF1278R;Database=ClothesShop;Trusted_Connection=True;MultipleActiveResultSets=true;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
