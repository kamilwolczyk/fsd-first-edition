using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels
{
    public class MonitorModel: ProductModel
    {
        [Range(0, 20, ErrorMessage = "Can only be between 0 .. 20")]
        [StringLength(2, ErrorMessage = "Max 2 digits")]
        [DisplayName("ResponseTime")]
        [Required(ErrorMessage = "ResponseTime cannot be empty")]
        public int ResponseTime { get; set; }

        [DisplayName("Size")]
        [Required(ErrorMessage = "Size cannot be empty")]
        public decimal Size { get; set; }

        public MonitorModel()
        {
            Type = Data.Enums.ProductType.Monitor;
        }
    }

}