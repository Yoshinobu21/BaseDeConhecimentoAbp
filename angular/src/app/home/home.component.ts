import { Component, Injector, ChangeDetectionStrategy, OnInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
  templateUrl: './home.component.html',
  animations: [appModuleAnimation()],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class HomeComponent extends AppComponentBase implements OnInit {

  products: ["teste1", "teste2"];

  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit(): void {
    this.products = ["teste1", "teste2"]
  }
}
