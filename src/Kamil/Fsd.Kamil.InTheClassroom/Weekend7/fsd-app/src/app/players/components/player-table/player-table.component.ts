import { ButtonConfiguration } from '../../../shared/button';
import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import { FootballPlayer, IPlayer, TennisPlayer, PlayerBase, PlayerLog, PlayerLevel } from '../../models';
import { PlayerService } from "app/players/services/player.service";

@Component({
  selector: 'app-player-table',
  templateUrl: './player-table.component.html',
  styleUrls: ['./player-table.component.css']
})
export class PlayerTableComponent implements OnInit {
  players: IPlayer[];
  introduceButtonConfig: ButtonConfiguration;
  playButtonConfig: ButtonConfiguration;

  @Output() onActionClick = new EventEmitter<PlayerLog>();

  constructor(private service: PlayerService) { }

  ngOnInit() {
    this.players = this.service.getPlayers();

    this.introduceButtonConfig = new ButtonConfiguration('Introduce');
    this.playButtonConfig = new ButtonConfiguration('Play');
  }

  introduceClick(message: string, player: IPlayer) {
    this.onActionClick.emit(new PlayerLog(player, player.introduce()));
  }

  playClick(message: string, player: IPlayer) {
    this.onActionClick.emit(new PlayerLog(player, player.play()));
  }

  getLevelName(level: PlayerLevel) {
    switch (level) {
      case PlayerLevel.Junior: return 'Junior player';
      case PlayerLevel.Medium: return 'Medium player';
      case PlayerLevel.Senior: return 'Senior player';
    }
  }
}
