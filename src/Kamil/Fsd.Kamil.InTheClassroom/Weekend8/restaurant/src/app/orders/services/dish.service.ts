import { IProductSource } from './productSource';
import { Injectable } from '@angular/core';
import { Product } from "app/orders";

@Injectable()
export class DishService implements IProductSource {
  private items: Product[];

  constructor() {
    this.items = [
      new Product(1, 'Pizza', 24),
      new Product(2, 'Frytki', 7),
      new Product(3, 'Schabowy z ziemniakami', 16),
    ];
  }

  getAll(): Product[] {
    return this.items;
  }
}
