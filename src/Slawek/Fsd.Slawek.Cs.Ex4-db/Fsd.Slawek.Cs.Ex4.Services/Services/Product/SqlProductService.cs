using System;
using System.Collections.Generic;
using Fsd.Slawek.Cs.Ex4.Data.Entities;
using Fsd.Slawek.Cs.Ex4.Data.Sql;
using Fsd.Slawek.Cs.Ex4.Data.Enums;

namespace Fsd.Slawek.Cs.Ex4.Services.Services.Product
{
    public class SqlProductService : IProductService
    {
        ITypesService<GraphicCard> _graphic;
        ITypesService<Monitor> _monitor;
        ITypesService<SoundCard> _sound;
        ITypesService<Processor> _processor;
        ITypesService<Motherboard> _motherboard;

        public SqlProductService(ITypesService<GraphicCard> x, ITypesService<Monitor> q, ITypesService<SoundCard> w,
            ITypesService<Processor> e, ITypesService<Motherboard> r)
        {
            _graphic=x;
            _monitor=q;
            _sound=w;
            _processor=e;
            _motherboard=r;
        }
        private List<ProductBase> _products = new List<ProductBase>();
        

        public IEnumerable<ProductBase> GetAllProducts()
        {
            List<ProductBase> lista = new List<ProductBase>();

            lista.AddRange(_monitor.GetAllProducts());
            lista.AddRange(_motherboard.GetAllProducts());
            lista.AddRange(_processor.GetAllProducts());
            lista.AddRange(_graphic.GetAllProducts());
            lista.AddRange(_sound.GetAllProducts());

            IEnumerable<ProductBase> result = lista;

            return result;
        }

        public ProductBase GetProduct(int id, ProductType type)
        {
            switch (type)
            {
                case ProductType.GraphicCard:
                    return _graphic.GetProduct(id);
                case ProductType.Monitor:
                    return _monitor.GetProduct(id);
                case ProductType.Motherboard:
                    return _motherboard.GetProduct(id);
                case ProductType.Processor:
                    return _processor.GetProduct(id);
                case ProductType.SoundCard:
                    return _sound.GetProduct(id);
                default:
                    return null;
            }
        }

        public int GetCount()
        {
            return new List<ProductBase>(GetAllProducts()).Count;
        }

        public void AddProduct(ProductBase cc)
        {
            WritingRepository rr = new WritingRepository();
            switch (cc.Type)
            {
                    case ProductType.GraphicCard:
                        rr.AddData((GraphicCard)cc);
                        break;
                    case ProductType.Monitor:
                        rr.AddData((Monitor)cc);
                        break;
                    case ProductType.Motherboard:
                        rr.AddData((Motherboard)cc);
                        break;
                    case ProductType.Processor:
                        rr.AddData((Processor)cc);
                        break;
                    case ProductType.SoundCard:
                        rr.AddData((SoundCard)cc);
                        break;
            }
        }
    }
}