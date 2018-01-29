using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels
{
    public class MotherboardModel: ProductModel
    {
        [DataType(DataType.Text)]
        [DisplayName("Chipset")]
        [StringLength(20, ErrorMessage = "Max 20 chars")]
        [Required(ErrorMessage = "Chipset cannot be empty")]
        public string Chipset { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Socket")]
        [StringLength(20, ErrorMessage = "Max 20 chars")]
        [Required(ErrorMessage = "Socket cannot be empty")]
        public string Socket { get; set; }

        public MotherboardModel()
        {
            Type = Data.Enums.ProductType.Motherboard;
        }
    }
}