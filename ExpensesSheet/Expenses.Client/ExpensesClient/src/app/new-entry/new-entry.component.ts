import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { Type } from '../Interfaces/Type';


@Component({
  selector: 'app-new-entry',
  templateUrl: './new-entry.component.html',
  styleUrls: ['./new-entry.component.css']
})
export class NewEntryComponent {

  types: Type[] = [
    { value: true , display:'Expense'  },
    { value: false , display:'Income'  }
  ]

  constructor() { }

  entryForm = new FormGroup({
    description: new FormControl(''),
    isExpense: new FormControl(''),
    value: new FormControl('')
  })
}
