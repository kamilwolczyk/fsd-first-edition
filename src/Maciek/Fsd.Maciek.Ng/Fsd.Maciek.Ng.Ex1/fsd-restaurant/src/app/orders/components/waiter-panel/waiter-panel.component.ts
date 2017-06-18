import { Component, OnInit } from '@angular/core';
import { TableConfiguration } from 'app/orders/components/table/tableConfiguration';
import { FoodService } from 'app/orders/services/food.service';
import { BeverageService } from 'app/orders/services/beverage.service';
import { OrderService } from 'app/orders/services/order.service';

@Component({
  selector: 'app-waiter-panel',
  templateUrl: './waiter-panel.component.html',
  styleUrls: ['./waiter-panel.component.css']
})
export class WaiterPanelComponent implements OnInit {
  foodTableConfig: TableConfiguration;
  beverageTableConfig: TableConfiguration;

  constructor(private foodService: FoodService, private beverageService: BeverageService, private orderService: OrderService) { }

  ngOnInit() {
    this.foodTableConfig = new TableConfiguration(this.foodService, 'Jedzenie');
    this.beverageTableConfig = new TableConfiguration(this.beverageService, 'Napoje');
  }

  resetButtonClick() {
    this.orderService.resetOrder();
  }
}
