import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PrivateIdeaCardComponent } from './private-idea-card.component';

describe('PrivateIdeaCardComponent', () => {
  let component: PrivateIdeaCardComponent;
  let fixture: ComponentFixture<PrivateIdeaCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PrivateIdeaCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PrivateIdeaCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
