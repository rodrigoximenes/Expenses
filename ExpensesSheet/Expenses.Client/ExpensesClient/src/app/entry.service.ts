import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Observable, Subject } from "rxjs";
import { EntryElement } from "./Interfaces/EntryElement";

@Injectable({
  providedIn: "root"
})
export class EntryService {
  baseUrl: string = "http://localhost:27123/api/entries/";

  constructor(private http: HttpClient) {}

  getEntry(id: number) {
    return this.http.get<EntryElement>(this.baseUrl + "/" + id);
  }

  getAll(): Observable<EntryElement[]> {
    return this.http.get<EntryElement[]>(this.baseUrl);
  }

  createEntry(entry: EntryElement) {
    return this.http.post<EntryElement>(this.baseUrl, entry);
  }

  updateEntry(id: number, entry: EntryElement) {
    return this.http.put<EntryElement>(this.baseUrl + "/" + id, entry);
  }

  deleteEntry(id: number) {
    return this.http.delete<EntryElement>(this.baseUrl + "/" + id);
  }
}
