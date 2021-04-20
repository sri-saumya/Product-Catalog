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
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DisplayProductComponent } from './display-product/display-product.component';
import { SearchProductComponent } from './search-product/search-product.component';
import { PsearchbynamePipe } from './psearchbyname.pipe';
import { PsearchbyidPipe } from './psearchbyid.pipe';
import { PsearchbypricePipe } from './psearchbyprice.pipe';
import { AddCategoryComponent } from './add-category/add-category.component';
import { AddProductComponent } from './add-product/add-product.component';
import { Pcmp1Component } from './pcmp1/pcmp1.component';
import { Pcmp2Component } from './pcmp2/pcmp2.component';
import { Ccmp1Component } from './ccmp1/ccmp1.component';
import { Ccmp2Component } from './ccmp2/ccmp2.component';

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
    PsearchbypricePipe,
    AddCategoryComponent,
    AddProductComponent,
    Pcmp1Component,
    Pcmp2Component,
    Ccmp1Component,
    Ccmp2Component
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
