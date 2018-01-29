using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Web.Models.ProductsModels;

namespace Fsd.Slawek.Cs.Ex4.Web.Models
{
    public static class ModelToEntityMaping
    {
        public static GraphicCard MapToEntity(GraphicCardModel model)
        {
            GraphicCard gc = new GraphicCard()
            {
                Producer = model.Producer,
                Model = model.Model,
                Type = model.Type,
                ProductionDate = model.ProductionDate,
                Price = model.Price,
                MemorySize = model.MemorySize,
                MemoryType = model.MemoryType
            };
            return gc;
        }

        public static Monitor MapToEntity(MonitorModel model)
        {
            Monitor gc = new Monitor()
            {
                Producer = model.Producer,
                Model = model.Model,
                Type = model.Type,
                ProductionDate = model.ProductionDate,
                Price = model.Price,
                ResponseTime = model.ResponseTime,
                Size = model.Size
            };
            return gc;
        }

        public static Processor MapToEntity(ProcessorModel model)
        {
            Processor gc = new Processor()
            {
                Producer = model.Producer,
                Model = model.Model,
                Type = model.Type,
                ProductionDate = model.ProductionDate,
                Price = model.Price,
                ClockSpeed = model.ClockSpeed,
                CacheSize = model.CacheSize
            };
            return gc;
        }

        public static SoundCard MapToEntity(SoundCardModel model)
        {
            SoundCard gc = new SoundCard()
            {
                Producer = model.Producer,
                Model = model.Model,
                Type = model.Type,
                ProductionDate = model.ProductionDate,
                Price = model.Price,
                Interfaces = model.Interfaces
            };
            return gc;
        }

        public static Motherboard MapToEntity(MotherboardModel model)
        {
            Motherboard gc = new Motherboard()
            {
                Producer = model.Producer,
                Model = model.Model,
                Type = model.Type,
                ProductionDate = model.ProductionDate,
                Price = model.Price,
                Chipset = model.Chipset,
                Socket = model.Socket
            };
            return gc;
        }
    }
}