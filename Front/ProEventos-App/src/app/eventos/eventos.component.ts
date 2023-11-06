import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  imgLarg=150;
  imgAlt=2;
  mostrarImagem: boolean = false;

  
  constructor(private http: HttpClient) { }
  ngOnInit(): void { 
    this.getEventos();
  }

  public getEventos(): void {
    this.http.get('https://localhost:7234/api/eventos').subscribe(
      response => 
        this.eventos = response,
        error => console.log(error)     
    );
    
  }
}
