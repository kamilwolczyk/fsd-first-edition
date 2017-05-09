using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Data.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Slawek.Cs.Ex4.Data.Sql
{
    public static class MappingType<TType>
    {
        public static TType Mapping(SqlDataReader reader)
        {
            var x = typeof(TType).Name;

            return (TType)typeof(MappingType<TType>).GetMethod($"{x}Type").Invoke(null,new object[] {reader});
        }

        public static Monitor MonitorType(SqlDataReader reader)
        {
            return new Monitor
            {  
                Id = (int)reader["Id"],
                Producer = (string)reader["Producer"],
                Model = (string)reader["Model"],
                Type = (ProductType)reader["Type"],
                ProductionDate = (DateTime)reader["ProductionDate"],
                Price = (decimal)reader["Price"],
                ResponseTime = (int)reader["ResponseTime"],
                Size = (decimal)reader["Size"]
            };
        }
        public static Motherboard MotherboardType(SqlDataReader reader)
        {
            return new Motherboard
            {
                Id = (int)reader["Id"],
                Producer = (string)reader["Producer"],
                Model = (string)reader["Model"],
                Type = (ProductType)reader["Type"],
                ProductionDate = (DateTime)reader["ProductionDate"],
                Price = (decimal)reader["Price"],
                Chipset = (string)reader["Chipset"],
                Socket = (string)reader["Socket"]
            };
        }

        public static Processor ProcessorType(SqlDataReader reader)
        {
            return new Processor
            {
                Id = (int)reader["Id"],
                Producer = (string)reader["Producer"],
                Model = (string)reader["Model"],
                Type = (ProductType)reader["Type"],
                ProductionDate = (DateTime)reader["ProductionDate"],
                Price = (decimal)reader["Price"],
                ClockSpeed = (int)reader["ClockSpeed"],
                CacheSize = (int)reader["CacheSize"]
            };
        }

        public static GraphicCard GraphicCardType(SqlDataReader reader)
        {
            return new GraphicCard
            {
                Id = (int)reader["Id"],
                Producer = (string)reader["Producer"],
                Model = (string)reader["Model"],
                Type = (ProductType)reader["Type"],
                ProductionDate = (DateTime)reader["ProductionDate"],
                Price = (decimal)reader["Price"],
                MemorySize = (decimal)reader["MemorySize"],
                MemoryType = (string)reader["MemoryType"]
            };
        }

        public static SoundCard SoundCardType(SqlDataReader reader)
        {
            return new SoundCard
            {
                Id = (int)reader["Id"],
                Producer = (string)reader["Producer"],
                Model = (string)reader["Model"],
                Type = (ProductType)reader["Type"],
                ProductionDate = (DateTime)reader["ProductionDate"],
                Price = (decimal)reader["Price"],
                Interfaces = (string)reader["Interfaces"]
            };
        }
    }
}
