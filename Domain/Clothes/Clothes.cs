using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Invoices;
using Domain.LaundryInvoices;

namespace Domain.Cloth
{
    [Table("Clothes")]
    public class Clothes
    {
        public Clothes()
        {
            this.DetailInvoices = new List<DetailInvoice>();
            this.DetailInvoiceLaundries = new List<DetailInvoiceLaundry>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [MaxLength(50)]
        public string Size { get; set; }
        public int? Price { get; set; }
        public int? RentalTime { get; set; }
        public int? RentalPrice { get; set; }
        public bool? IsRental { get; set; }
        public int? IDType { get; set; }
        public int? IDOrigin { get; set; }

        public TypeClothes TypeCloth { get; set; }
        public Origin Origin { get; set; }
        public List<DetailInvoice> DetailInvoices { get; set; }
        public List<DetailInvoiceLaundry> DetailInvoiceLaundries { get; set; }
    }
}

