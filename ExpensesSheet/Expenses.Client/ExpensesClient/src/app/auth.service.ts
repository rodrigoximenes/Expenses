import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { registerContentQuery } from '@angular/core/src/render3';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  baseUrl: string = 'http://localhost:27123/auth/'

  constructor(private http: HttpClient) {}

  register(user){
    return this.http.post(this.baseUrl+'register',user);
  }

  login(user){
    return this.http.post(this.baseUrl+'login',user);
  }
}
