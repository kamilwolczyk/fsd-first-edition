import { Product } from './product';

export class Food extends Product {
    constructor(
        public id: number,
        public name: string,
        public description: string,
        public price: number) {
        super(id, name, description, price)
    }
}

