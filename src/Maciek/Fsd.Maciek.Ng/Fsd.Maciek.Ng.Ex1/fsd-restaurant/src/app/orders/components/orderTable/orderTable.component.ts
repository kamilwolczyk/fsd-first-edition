import { Component, OnInit } from '@angular/core';
import { Order } from 'app/orders/models/order';
import { Food, Beverage } from 'app/orders/models';
import { OrderService } from 'app/orders/services/order.service';

@Component({
  selector: 'app-order',
  templateUrl: './orderTable.component.html',
  styleUrls: ['./orderTable.component.css']
})

export class OrderTableComponent implements OnInit {
  order: Order;
  constructor(private orderService: OrderService) {
    this.order = new Order();
  }

  ngOnInit() {
    this.orderService.orderStream.subscribe((newOrder: Order) => {
      this.order = newOrder;
    });
  }

}
