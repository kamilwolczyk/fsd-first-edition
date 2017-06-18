import { Product } from 'app/orders/models';

export class OrderItem {
    constructor(
        public product: Product,
        public quantity: number
    ) { };
}
