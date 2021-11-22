import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { GymComponent } from './gym/gym.component';
import { RunComponent } from './run/run.component';
import { SwimComponent } from './swim/swim.component';
import { WearComponent } from './wear/wear.component';
import { CategoryComponent } from './category/category.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    GymComponent,
    RunComponent,
    SwimComponent,
    WearComponent,
    CategoryComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'gym', component: GymComponent },
      { path: 'run', component: RunComponent },
      { path: 'swim', component: SwimComponent },
      { path: 'wear', component: WearComponent },
      { path: 'category', component: CategoryComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
