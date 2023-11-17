import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EventoService {

  baseUrl = 'https://localhost:7234/api/eventos';

  constructor(private http: HttpClient) { }

  public getEvento(){
    return this.http.get(this.baseUrl);
  }
}
