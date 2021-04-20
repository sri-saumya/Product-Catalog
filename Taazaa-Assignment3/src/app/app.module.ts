import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { CategoryComponent } from './category/category.component';
import { ProductComponent } from './product/product.component';
import { DisplayCategoryComponent } from './display-category/display-category.component';
import { SearchCategoryComponent } from './search-category/search-category.component';
import { SearchbyidPipe } from './searchbyid.pipe';
import { SearchbynamePipe } from './searchbyname.pipe';
import { FormsModule } from '@angular/forms';
import { DisplayProductComponent } from './display-product/display-product.component';
import { SearchProductComponent } from './search-product/search-product.component';
import { PsearchbynamePipe } from './psearchbyname.pipe';
import { PsearchbyidPipe } from './psearchbyid.pipe';
import { PsearchbypricePipe } from './psearchbyprice.pipe';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CategoryComponent,
    ProductComponent,
    DisplayCategoryComponent,
    SearchCategoryComponent,
    SearchbyidPipe,
    SearchbynamePipe,
    DisplayProductComponent,
    SearchProductComponent,
    PsearchbynamePipe,
    PsearchbyidPipe,
    PsearchbypricePipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
