import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ICategory } from '../category/ICategory';
import { CsharingService } from '../csharing.service';

@Component({
  selector: 'app-ccmp1',
  templateUrl: './ccmp1.component.html',
  styleUrls: ['./ccmp1.component.css']
})
export class Ccmp1Component implements OnInit {

  crod : ICategory;

  categoryform : FormGroup;

  constructor(private Csharing:CsharingService) { }

  ngOnInit(): void {
    this.Csharing.categories$.subscribe(data =>{
      this.crod = data;
    })
    this.categoryform = new FormGroup(
      {
        Category_ID : new FormControl(this.crod?.Category_ID,[Validators.required]),
        Category_Name : new FormControl(this.crod?.Category_Name,[Validators.required]),
        CategoryShortCode : new FormControl(this.crod?.CategoryShortCode,[Validators.required]),
        CategoryDescription : new FormControl(this.crod?.CategoryDescription,[Validators.required]),

      }
    )

  }
  updateCategory(){
      this.Csharing.updateCategory(this.categoryform.value);
  }

}
