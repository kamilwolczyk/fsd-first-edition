import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { MainComponent } from 'app/main/main.component';
import { FoodService } from './orders/services/food.service';
import { HeaderComponent } from './layout/header/header.component';
import { TableComponent } from './orders/components/table/table.component';
import { BeverageService } from 'app/orders/services/beverage.service';
import { OrderTableComponent } from 'app/orders/components/orderTable/orderTable.component';
import { FooterComponent } from './layout/footer/footer.component';
import { WaiterPanelComponent } from 'app/orders/components/waiter-panel/waiter-panel.component';
import { TestComponent } from './test/test.component';
import { OrderService } from 'app/orders/services/order.service';
import { LoginFormComponent } from './users/components/login-form/login-form.component';
import { HomeComponent } from './static/home/home.component';
import { RouterModule } from '@angular/router'
import { AppRoutes } from "app/routes";

@NgModule({
  declarations: [
    MainComponent,
    HeaderComponent,
    TableComponent,
    OrderTableComponent,
    FooterComponent,
    WaiterPanelComponent,
    TestComponent,
    LoginFormComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(AppRoutes)
  ],
  providers: [
    FoodService,
    BeverageService,
    OrderService
  ],
  bootstrap: [MainComponent]
})
export class AppModule { }
