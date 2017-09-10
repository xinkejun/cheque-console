import { NgModule } from '@angular/core';

import { SharedModule } from '../shared/shared.module';
import { TechnicalTestRoutingModule } from './technical-test-routing.module';

import { CountrySearchComponent } from './iasset/country-search.component';

@NgModule({
  imports: [
    SharedModule,
    TechnicalTestRoutingModule,
  ],
  declarations: [
    CountrySearchComponent,
  ],
})
export class TechnicalTestModule { }