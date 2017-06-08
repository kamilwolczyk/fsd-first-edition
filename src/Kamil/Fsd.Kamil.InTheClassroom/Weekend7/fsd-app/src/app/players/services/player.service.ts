import { Injectable } from '@angular/core';
import { IPlayer, FootballPlayer, TennisPlayer, PlayerLevel } from 'app/players/models';

@Injectable()
export class PlayerService {
  private mockPlayers = [
    new FootballPlayer('Cristiano', 'Ronaldo', PlayerLevel.Senior),
    new FootballPlayer('Lionel', 'Messi', PlayerLevel.Medium),
    new TennisPlayer('Roger', 'Federrer', PlayerLevel.Medium),
    new FootballPlayer('Robert', 'Lewandowski', PlayerLevel.Medium),
    new TennisPlayer('Agnieszka', 'Radwańska', PlayerLevel.Junior)
  ];

  getPlayers(): IPlayer[] {
    return this.mockPlayers;
  }

  getPlayerByFullName(name: string): IPlayer {
    const results = this.mockPlayers.filter(x => x.getFullName() === name);

    return results.length > 0 ? results[0] : null;
  }
}
