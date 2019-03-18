import { Component, OnInit } from '@angular/core';
import { EntryService } from '../entry.service';
import { EntryElement } from '../Interfaces/EntryElement';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'app-entries',
  templateUrl: './entries.component.html',
  styleUrls: ['./entries.component.css']
})
export class EntriesComponent implements OnInit {

  displayedColumns: string[] = ['Description','IsExpense','Value','Actions']
  dataSource;

  constructor(private service: EntryService) { }

  ngOnInit() {
    this.service.getAll().subscribe((data) => {
      console.log('Result -', data);
      this.dataSource = new MatTableDataSource<EntryElement>(data as EntryElement[]);
    })
  }

  updateEntry(entry){
    console.log(entry);
  }

}
