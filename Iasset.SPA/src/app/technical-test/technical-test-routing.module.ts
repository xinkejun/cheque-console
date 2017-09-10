import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CountrySearchComponent } from './iasset/country-search.component';

const routes: Routes = [
    {
        path: '',
        children: [
            {
                path: 'country-search',
                component: CountrySearchComponent,
            },
        ]
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class TechnicalTestRoutingModule { }