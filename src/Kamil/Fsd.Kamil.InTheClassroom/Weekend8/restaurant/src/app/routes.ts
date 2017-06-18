import { LoginFormComponent } from './users/components/login-form/login-form.component';
import { WaiterPanelComponent } from './orders/components/waiter-panel/waiter-panel.component';
import { HomeComponent } from "app/static/home/home.component";

export const AppRoutes = [
  { path: 'home', component: HomeComponent },
  { path: 'orders', component: WaiterPanelComponent },
  { path: 'login', component: LoginFormComponent },
  { path: '', redirectTo: 'home', pathMatch: 'full' }
];