import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Order } from 'app/orders/models/order';
import { Product } from 'app/orders/models';

@Injectable()
export class OrderService {
  private currentOrder: Order;
  orderStream: Subject<Order>;

  constructor() {
    this.orderStream = new Subject<Order>();
  }
  resetOrder(): void {
    this.currentOrder = new Order();
    this.orderStream.next(this.currentOrder);
  }

  addProduct(product: Product): void {
    if (this.currentOrder == null) {
      this.currentOrder = new Order();
    }
    this.currentOrder.addProduct(product);
    this.orderStream.next(this.currentOrder);
  }
}
