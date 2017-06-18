import { Component, OnInit, Input } from '@angular/core';
import { Product } from 'app/orders/models/product';
import { TableConfiguration } from 'app/orders/components/table/tableConfiguration';
import { OrderService } from 'app/orders/services/order.service';

@Component({
  selector: 'app-product-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit {
  products: Product[];
  title: string;
  @Input() configuration: TableConfiguration;

  constructor(private orderService: OrderService) { }

  ngOnInit() {
    this.products = this.configuration.service.getAllProducts();
    this.title = this.configuration.title;
  }
  selectProduct(product) {
    console.log(product)
    this.orderService.addProduct(product);
  }
}
