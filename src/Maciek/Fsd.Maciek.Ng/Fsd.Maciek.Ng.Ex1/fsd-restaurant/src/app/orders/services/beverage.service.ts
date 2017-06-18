import { Injectable } from '@angular/core';
import { Beverage, Product } from 'app/orders/models';
import { IProductService } from './IproductService';

@Injectable()
export class BeverageService implements IProductService {
  private mockBeverages = [
    new Beverage(6, 'Woda mineralna niegazowana', 'Woda mineralna Żywiec Zdrój niegazowana', 4),
    new Beverage(7, 'Woda mineralna gazowana', 'Woda mineralna Żywiec Zdrój gazowana', 4),
    new Beverage(8, 'Piwo Paulaner', 'Pszeniczne piwo Paulaner', 11),
    new Beverage(9, 'Wino Carlo Rossi Muscato', 'Różowe wino Carlo Rossi Muscato. Butelka 0.7l', 29)
  ];

  getAllProducts(): Product[] {
    return this.mockBeverages;
  }
}
