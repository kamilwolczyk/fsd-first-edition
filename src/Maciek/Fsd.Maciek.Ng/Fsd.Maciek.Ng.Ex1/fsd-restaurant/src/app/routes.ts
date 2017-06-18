import { WaiterPanelComponent } from 'app/orders/components/waiter-panel/waiter-panel.component';
import { LoginFormComponent } from 'app/users/components/login-form/login-form.component';

export const AppRoutes = [
    { path: 'orders', component: WaiterPanelComponent },
    { path: 'login', component: LoginFormComponent },
    { path: '', redirectTo: 'login', pathMatch: 'full' }
];
