import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { ICategory } from './category/ICategory';

@Injectable({
  providedIn: 'root'
})
export class CsharingService {

    crod : ICategory = {
      Category_ID :1,
      Category_Name : "Grocery",
      CategoryShortCode : "101",
      CategoryDescription : "Well Satisfied"
  }

  categories$ : BehaviorSubject<ICategory>

  constructor() {
    this.categories$ = new BehaviorSubject(this.crod);
   }


   updateCategory(p : ICategory){
    this.crod = {
      ...p
    }
    this.categories$.next(this.crod);
  }

}
