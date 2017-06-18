import { OrderItem } from 'app/orders/models/orderItem';
import { Product } from 'app/orders/models';

export class Order {
    items: OrderItem[];
    totalPrice: number;

    constructor() {
        this.items = [];
        this.totalPrice = 0;
    }
    recalculate(): void {
        let sum = 0;
        this.items.forEach((item: OrderItem) => {
            sum += item.quantity * item.product.price;
        });
        this.totalPrice = sum;
    }

    addProduct(product: Product) {
        let existingProduct = this.items.find(item => item.product.id === product.id);

        if (existingProduct == null) {
            this.items.push(new OrderItem(product, 1))
        } else {
            existingProduct.quantity++;
        }
    }
}
