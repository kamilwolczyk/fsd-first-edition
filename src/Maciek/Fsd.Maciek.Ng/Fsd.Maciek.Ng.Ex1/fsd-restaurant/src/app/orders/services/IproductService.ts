import { Product } from 'app/orders/models';

export interface IProductService {
    getAllProducts(): Product[];
}
