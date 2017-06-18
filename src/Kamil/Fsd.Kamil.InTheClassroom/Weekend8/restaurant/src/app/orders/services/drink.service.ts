import { Injectable } from '@angular/core';
import { Product, IProductSource } from "app/orders";

@Injectable()
export class DrinkService implements IProductSource {
  private items: Product[];

  constructor() {
    this.items = [
      new Product(10, 'piwo', 7),
      new Product(11, 'woda', 3),
      new Product(12, 'wino', 17),
    ]
  }

  getAll(): Product[] {
    return this.items;
  }
}
