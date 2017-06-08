import { ButtonConfiguration } from './models/buttonConfiguration';
import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent {
  @Input() config: ButtonConfiguration;
  @Output() onButtonClick = new EventEmitter<string>();

  clickAction() {
    this.onButtonClick.emit();
  }
}
