import { Component, OnInit } from '@angular/core';
import { ICategory } from '../category/ICategory';
import { CsharingService } from '../csharing.service';


@Component({
  selector: 'app-ccmp2',
  templateUrl: './ccmp2.component.html',
  styleUrls: ['./ccmp2.component.css']
})
export class Ccmp2Component implements OnInit {


  categories : ICategory ;
  constructor(private Csharing : CsharingService) { }

  ngOnInit(): void {
    
    this.Csharing.categories$.subscribe(c => {
      this.categories = c; 
   });
    
  }

}
