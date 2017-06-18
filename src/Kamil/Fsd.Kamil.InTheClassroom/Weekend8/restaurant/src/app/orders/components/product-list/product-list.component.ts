import { OrderService } from '../../services/order.service';
import { IProductSource } from '../../services/productSource';
import { Component, OnInit, Input } from '@angular/core';
import { Product } from "app/orders";

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  @Input() title: string;
  @Input() source: IProductSource;
  products: Product[];

  constructor(private orderService: OrderService) {  }

  ngOnInit() {
    this.products = this.source.getAll();
  }

  selectProduct(product:Product): void{
    console.log(product);
    this.orderService.addProduct(product);

  }
}
