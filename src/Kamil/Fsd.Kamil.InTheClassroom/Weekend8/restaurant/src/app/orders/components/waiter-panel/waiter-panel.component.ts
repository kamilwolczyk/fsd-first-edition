import { OrderService } from '../../services/order.service';
import { DishService } from '../../services/dish.service';
import { Component, OnInit } from '@angular/core';
import { DrinkService } from "app/orders";

@Component({
  selector: 'app-waiter-panel',
  templateUrl: './waiter-panel.component.html',
  styleUrls: ['./waiter-panel.component.css']
})
export class WaiterPanelComponent implements OnInit {

  constructor(public dishService: DishService,
    public drinkService: DrinkService,
    private orderService: OrderService) { }

  ngOnInit() {
  }

  resetButtonClick() {
    this.orderService.resetOrder();
  }

}
