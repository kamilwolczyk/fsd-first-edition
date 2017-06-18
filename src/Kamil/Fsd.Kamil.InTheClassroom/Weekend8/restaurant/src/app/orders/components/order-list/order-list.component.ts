import { Order } from '../../models/order';
import { Component, OnInit } from '@angular/core';
import { Product } from "app/orders";
import { OrderService } from "app/orders/services/order.service";

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css']
})
export class OrderListComponent implements OnInit {
  order: Order;

  constructor(private orderService: OrderService) { 
    this.order = new Order();
  }

  ngOnInit() {
    this.orderService.orderStream.subscribe((newOrder: Order)=>{
      this.order = newOrder;
    })
  }

}
