import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';

import { MainComponent } from './main/main.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { DishService, DrinkService } from "app/orders";
import { ProductListComponent } from './orders/components/product-list/product-list.component';
import { OrderListComponent } from './orders/components/order-list/order-list.component';
import { WaiterPanelComponent } from './orders/components/waiter-panel/waiter-panel.component';
import { OrderService } from "app/orders/services/order.service";
import { LoginFormComponent } from './users/components/login-form/login-form.component';
import { HomeComponent } from './static/home/home.component';
import { AppRoutes } from "app/routes";

@NgModule({
  declarations: [
    MainComponent,
    HeaderComponent,
    FooterComponent,
    ProductListComponent,
    OrderListComponent,
    WaiterPanelComponent,
    LoginFormComponent,
    HomeComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(AppRoutes)
  ],
  providers: [
    DishService,
    DrinkService,
    OrderService
  ],
  bootstrap: [MainComponent]
})
export class AppModule { }
