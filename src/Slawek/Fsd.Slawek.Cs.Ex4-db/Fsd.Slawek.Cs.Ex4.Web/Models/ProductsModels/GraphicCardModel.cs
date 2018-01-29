using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels
{
    public class GraphicCardModel: ProductModel
    {
        [DataType(DataType.Currency)]
        [DisplayName("MemorySize")]
        [Required(ErrorMessage = "MemorySize cannot be empty")]
        public decimal MemorySize { get; set; }

        [DataType(DataType.Text)]
        [StringLength(10, ErrorMessage = "Max 10 chars")]
        [DisplayName("MemoryType")]
        [Required(ErrorMessage = "MemoryType cannot be empty")]
        public string MemoryType { get; set; }

        public GraphicCardModel()
        {
            Type = Data.Enums.ProductType.GraphicCard;
        }
    }

}