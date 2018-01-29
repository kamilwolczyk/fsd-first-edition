using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Services.Services.Product;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Slawek.Cs.Ex4.Web.Controllers
{
    public class HomeController : Controller
    {
        IProductService _service;

        public HomeController(IProductService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            int model = _service.GetCount();

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(string type)
        {
            if (!ModelState.IsValid)
                return View();
            
            if(type != "Selects items") return RedirectToAction("Create", $"{type}");
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Some information about me.";

            return View();
        }
    }
}





//            MemoryProductService xx = new MemoryProductService();
//            var cc = (Motherboard)xx.GetProduct(2);
//            string ConnectionString = ConfigurationManager.ConnectionStrings["localDatabase"].ConnectionString;

//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            {
//                connection.Open();
//                //SqlCommand command = new SqlCommand($"Insert into GraphicCard (Producer,Model,Type,ProductionDate,Price,MemorySize,MemoryType) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},{cc.MemorySize},'{cc.MemoryType}')", connection);
//                //SqlCommand command = new SqlCommand($"Insert into Monitor (Producer,Model,Type,ProductionDate,Price,ResponseTime,Size) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},{cc.ResponseTime},{cc.Size})", connection);
//                //SqlCommand command = new SqlCommand($"Insert into Processor (Producer,Model,Type,ProductionDate,Price,ClockSpeed,CacheSize) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},{cc.ClockSpeed},{cc.CacheSize})", connection);
//                //SqlCommand command = new SqlCommand($"Insert into SoundCard (Producer,Model,Type,ProductionDate,Price,Interfaces) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},'{cc.Interfaces}')", connection);
//                SqlCommand command = new SqlCommand($"Insert into Motherboard (Producer,Model,Type,ProductionDate,Price,Chipset,Socket) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},'{cc.Chipset}','{cc.Socket}')", connection);
////SqlCommand command = new SqlCommand($"Update GraphicCard SET Producer = 'Asus',Model ='GeForce GTX 1070',ProductionDate='{new DateTime(2017,02,02).ToString("yyyy-MM-dd")}',Price = 2059.00,MemorySize = 8,MemoryType = 'GDDR5' WHERE Id=1", connection);
//                //SqlCommand command = new SqlCommand("Execute dbo.f_GetRecordCount", connection);
//               // var liczba = command.ExecuteScalar().ToString();
//                SqlDataReader reader = command.ExecuteReader();
//            }