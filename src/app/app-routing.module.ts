import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AboutComponent } from './about/about.component';

import { ChequeListComponent } from './cheques/cheque-list.component';
import { ChequeDetailComponent } from './cheques/cheque-detail.component';

const routes: Routes = [
  { path: '', redirectTo: '/cheques', pathMatch: 'full' },
  { path: 'cheques', component: ChequeListComponent },
  { path: 'cheques/:id', component: ChequeDetailComponent },
  { path: 'about', component: AboutComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
