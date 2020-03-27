import { Component, OnInit } from "@angular/core";
import { EntryService } from "../entry.service";
import { MatDialog } from "@angular/material";
import { UpdateEntryComponent } from "../update-entry/update-entry.component";

@Component({
  selector: "app-entries",
  templateUrl: "./entries.component.html",
  styleUrls: ["./entries.component.css"]
})
export class EntriesComponent implements OnInit {
  displayedColumns: string[] = ["Description", "IsExpense", "Value", "Actions"];
  entries$ = this.service.getAll();

  constructor(private service: EntryService, private dialog: MatDialog) {}

  ngOnInit() {}

  updateEntry(entry) {
    console.log(entry);
    let dialogRef = this.dialog.open(UpdateEntryComponent, {
      data: {
        Id: entry.Id,
        Description: entry.Description,
        IsExpense: entry.IsExpense,
        Value: entry.Value
      }
    });
    dialogRef.afterClosed().subscribe(() =>
      this.entries$ = this.service.getAll()
      );
  }
}
