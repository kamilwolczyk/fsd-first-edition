import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { MainComponent } from './main/main.component';
import { HeaderComponent } from './header/header.component';
import { ButtonComponent } from './shared/button/button.component';
import { PlayerTableComponent } from './players/components/player-table/player-table.component';
import { ClockComponent } from './clock/clock.component';
import { PlayerLogComponent } from './players/components/player-log/player-log.component';
import { PlayerService } from 'app/players/services/player.service';

@NgModule({
  declarations: [
    MainComponent,
    HeaderComponent,
    ButtonComponent,
    PlayerTableComponent,
    ClockComponent,
    PlayerLogComponent
  ],
  imports: [
    BrowserModule,
  ],
  providers: [
    PlayerService
  ],
  bootstrap: [MainComponent]
})
export class AppModule { }
