import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WearComponent } from './wear.component';

describe('WearComponent', () => {
  let component: WearComponent;
  let fixture: ComponentFixture<WearComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WearComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
