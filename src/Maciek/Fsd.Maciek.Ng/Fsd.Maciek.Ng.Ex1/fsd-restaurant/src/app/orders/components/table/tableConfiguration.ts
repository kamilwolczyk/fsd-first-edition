import { IProductService } from 'app/orders/services/IproductService';
import { FoodService } from 'app/orders/services/food.service';

export class TableConfiguration {
    constructor(
        public service: IProductService,
        public title: string) {}
}
