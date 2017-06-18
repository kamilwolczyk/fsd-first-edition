import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WaiterPanelComponent } from './waiter-panel.component';

describe('WaiterPanelComponent', () => {
  let component: WaiterPanelComponent;
  let fixture: ComponentFixture<WaiterPanelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WaiterPanelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WaiterPanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
