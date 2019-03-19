import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { EntryService } from '../entry.service';

@Component({
  selector: 'app-delete-entry',
  templateUrl: './delete-entry.component.html',
  styleUrls: ['./delete-entry.component.css']
})
export class DeleteEntryComponent implements OnInit {

  entry={
    description:'',
    value:0,
    isExpense:false
  }

  id;

  constructor(private route: ActivatedRoute,
              private service: EntryService) { }

  ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id');
    this.service.getEntry(this.id).subscribe((data: any)=>{
      console.log(data);
      this.entry.description = data.Description;
      this.entry.isExpense = data.IsExpense;
      this.entry.value = data.Value;
    })
  }

  cancel(){
    console.log('Cancel clicked');
  }

  confirm(){
    console.log('Confirm clicked');
  }
}
