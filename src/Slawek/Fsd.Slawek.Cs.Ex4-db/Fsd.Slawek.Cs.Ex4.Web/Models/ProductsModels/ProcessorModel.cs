using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels
{
    public class ProcessorModel: ProductModel
    {
        [Range(1, 100000, ErrorMessage = "Can only be between 1 .. 100000 MHz")]
        [StringLength(6, ErrorMessage = "Max 6 digits")]
        [DisplayName("ClockSpeed")]
        [Required(ErrorMessage = "ClockSpeed cannot be empty")]
        public int ClockSpeed { get; set; }

        [Range(1, 1000, ErrorMessage = "Can only be between 1 .. 1000 MB")]
        [StringLength(6, ErrorMessage = "Max 4 digits")]
        [DisplayName("CacheSize")]
        [Required(ErrorMessage = "CacheSize cannot be empty")]
        public int CacheSize { get; set; }

        public ProcessorModel()
        {
            Type = Data.Enums.ProductType.Processor;
        }
    }

}