import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Subject, combineLatest, Observable } from 'rxjs';
import { map, tap } from 'rxjs/operators';
import { EntryElement } from './Interfaces/EntryElement';

@Injectable({
  providedIn: 'root'
})
export class EntryService {

  baseUrl: string = 'http://localhost:27123/api/entries/';

  private updatedEntrydSubject = new Subject<EntryElement>();
  updatedEntryAction$ = this.updatedEntrydSubject.asObservable();

  constructor(private http: HttpClient) { }

  entries$ = this.http.get(this.baseUrl) as Observable<EntryElement>;

  getEntry(id: number){
    return this.http.get<EntryElement>(this.baseUrl+'/'+id);
  }

  getAll(){
    return this.http.get<EntryElement[]>(this.baseUrl);
  }

  createEntry(entry: EntryElement){
    return this.http.post<EntryElement>(this.baseUrl, entry);
  }

  updateEntry(id: number, entry: EntryElement){
    return this.http.put<EntryElement>(this.baseUrl+'/'+id,entry);
  }

  deleteEntry(id: number){
    return this.http.delete<EntryElement>(this.baseUrl+'/'+id);
  }
}
