using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Data.Enums;

namespace Fsd.Slawek.Cs.Ex4.Data.Sql
{
    public class WritingRepository
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["localDatabase"].ConnectionString;

        public void AddData(ProductBase product)
        {
            
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = CommandGenerator(product, connection);
                //SqlCommand command = new SqlCommand($"Insert into GraphicCard (Producer,Model,Type,ProductionDate,Price,MemorySize,MemoryType) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},{cc.MemorySize},'{cc.MemoryType}')", connection);
                //SqlCommand command = new SqlCommand($"Insert into Monitor (Producer,Model,Type,ProductionDate,Price,ResponseTime,Size) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},{cc.ResponseTime},{cc.Size})", connection);
                //SqlCommand command = new SqlCommand($"Insert into Processor (Producer,Model,Type,ProductionDate,Price,ClockSpeed,CacheSize) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},{cc.ClockSpeed},{cc.CacheSize})", connection);
                //SqlCommand command = new SqlCommand($"Insert into SoundCard (Producer,Model,Type,ProductionDate,Price,Interfaces) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},'{cc.Interfaces}')", connection);
                //SqlCommand command = new SqlCommand($"Insert into Motherboard (Producer,Model,Type,ProductionDate,Price,Chipset,Socket) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},'{cc.Chipset}','{cc.Socket}')", connection);
                //SqlCommand command = new SqlCommand($"Update GraphicCard SET Producer = 'Asus',Model ='GeForce GTX 1070',ProductionDate='{new DateTime(2017,02,02).ToString("yyyy-MM-dd")}',Price = 2059.00,MemorySize = 8,MemoryType = 'GDDR5' WHERE Id=1", connection);
                //SqlCommand command = new SqlCommand("Execute dbo.f_GetRecordCount", connection);
                // var liczba = command.ExecuteScalar().ToString();
                command.ExecuteNonQuery();
                //SqlDataReader reader = command.ExecuteReader();
            }
        }

        private SqlCommand CommandGenerator(ProductBase cc, SqlConnection connection)
        {
            switch (cc.Type)
            {
                case ProductType.GraphicCard:
                    var gc = (GraphicCard) cc;
                    return new SqlCommand($"Insert into GraphicCard (Producer,Model,Type,ProductionDate,Price,MemorySize,MemoryType) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}','{cc.Price}','{gc.MemorySize}','{gc.MemoryType}')", connection);
                case ProductType.Monitor:
                    var monitor = (Monitor)cc;
                    return new SqlCommand($"Insert into Monitor (Producer,Model,Type,ProductionDate,Price,ResponseTime,Size) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},{monitor.ResponseTime},{monitor.Size})", connection);
                case ProductType.Motherboard:
                    var motherBoard = (Motherboard)cc;
                    return new SqlCommand($"Insert into Motherboard (Producer,Model,Type,ProductionDate,Price,Chipset,Socket) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},'{motherBoard.Chipset}','{motherBoard.Socket}')", connection);
                case ProductType.Processor:
                    var processor = (Processor)cc;
                    return new SqlCommand($"Insert into Processor (Producer,Model,Type,ProductionDate,Price,ClockSpeed,CacheSize) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},{processor.ClockSpeed},{processor.CacheSize})", connection);
                case ProductType.SoundCard:
                    var soundCard = (SoundCard)cc;
                    return new SqlCommand($"Insert into SoundCard (Producer,Model,Type,ProductionDate,Price,Interfaces) values ('{cc.Producer}','{cc.Model}','{(int)cc.Type}','{cc.ProductionDate.ToString("yyyy-MM-dd")}',{cc.Price},'{soundCard.Interfaces}')", connection);
            }
            return null;
        }
    }
}