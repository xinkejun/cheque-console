import { NgModule } from '@angular/core';

import { P404Component } from './404.component';

import { SharedModule } from '../shared/shared.module';
import { PagesRoutingModule } from './pages-routing.module';

@NgModule({
  imports: [
    SharedModule,
    PagesRoutingModule,
  ],
  declarations: [
    P404Component,
  ]
})
export class PagesModule { }