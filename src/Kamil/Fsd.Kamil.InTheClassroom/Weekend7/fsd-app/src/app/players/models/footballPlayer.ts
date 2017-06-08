import { IPlayer, PlayerBase } from './player';

export class FootballPlayer extends PlayerBase implements IPlayer {
  constructor(firstName: string, lastName: string, playerLevel: PlayerLevel) {
    super(firstName, lastName, playerLevel);
  }

  public introduce(): string {
    return `Nazywam się ${super.getFullName()} i jestem piłkarzem`;
  }

  public play(): string {
    return 'Gram w piłkę';
  }
}
