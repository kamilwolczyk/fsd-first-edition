using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels
{
    public class SoundCardModel: ProductModel
    {
        [DataType(DataType.Text)]
        [DisplayName("Interfaces")]
        [StringLength(15, ErrorMessage = "Max 15 chars")]
        [Required(ErrorMessage = "Interfaces cannot be empty")]
        public string Interfaces { get; set; }

        public SoundCardModel()
        {
            Type = Data.Enums.ProductType.SoundCard;
        }
    }

}