import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreateComponent } from './create/create.component';


const routes: Routes = [
  { path: 'post', redirectTo: 'post/create', pathMatch: 'full'},
  { path: 'post/create', component: CreateComponent },
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AttendanceRoutingModule { }
